using ProcessSchedulingSimulatorWinForms.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessSchedulingSimulatorWinForms.Algorithms
{
    public abstract class AlgoritmoEscalonamento
    {
        public string Nome { get; set; }
        public List<Processo> Processos { get; set; }
        public List<string> HistoricoExecucao { get; set; }
        public Metricas MetricasSimulacao { get; set; }

        protected AlgoritmoEscalonamento()
        {
            Processos = new List<Processo>();
            HistoricoExecucao = new List<string>();
            MetricasSimulacao = new Metricas();
        }

        public abstract void Executar();

        protected void CalcularMetricas()
        {
            if (Processos.Count == 0) return;

            int totalEspera = 0;
            int totalRetorno = 0;
            int totalResposta = 0;

            foreach (var processo in Processos)
            {
                processo.TempoRetorno = processo.TempoFinal - processo.TempoChegada;
                processo.TempoEspera = processo.TempoRetorno - processo.TempoCPU;

                totalEspera += processo.TempoEspera;
                totalRetorno += processo.TempoRetorno;

                if (processo.TempoInicio >= 0)
                    totalResposta += processo.TempoInicio - processo.TempoChegada;
            }

            MetricasSimulacao.TempoEsperaMedio = (double)totalEspera / Processos.Count;
            MetricasSimulacao.TempoRetornoMedio = (double)totalRetorno / Processos.Count;
            MetricasSimulacao.TempoRespostaMedio = (double)totalResposta / Processos.Count;

            int maxTempoFinal = Processos.Max(p => p.TempoFinal);
            MetricasSimulacao.TempoExecucaoTotal = maxTempoFinal;
            MetricasSimulacao.Vazao = (double)Processos.Count / maxTempoFinal;
        }

        protected void AdicionarHistorico(int tempo, string nomeProcesso, string acao)
        {
            HistoricoExecucao.Add($"{tempo} | {nomeProcesso} | {acao}");
        }
    }
}