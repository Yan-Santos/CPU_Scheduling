using ProcessSchedulingSimulatorWinForms.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessSchedulingSimulatorWinForms.Algorithms
{
    public class SJF : AlgoritmoEscalonamento
    {
        public SJF()
        {
            Nome = "SJF (Trabalho Mais Curto Primeiro)";
        }

        public override void Executar()
        {
            HistoricoExecucao.Clear();

            var processos = Processos.Select(p => p.Clonar()).ToList();
            var concluidos = new List<Processo>();
            int tempoAtual = 0;

            while (processos.Count > 0)
            {
                var disponiveis = processos.Where(p => p.TempoChegada <= tempoAtual).ToList();

                if (disponiveis.Count == 0)
                {
                    tempoAtual++;
                    continue;
                }

                var proximoProcesso = disponiveis.OrderBy(p => p.TempoCPU).First();
                processos.Remove(proximoProcesso);

                proximoProcesso.TempoInicio = tempoAtual;
                AdicionarHistorico(tempoAtual, proximoProcesso.Nome, "Iniciou");

                tempoAtual += proximoProcesso.TempoCPU;
                proximoProcesso.TempoFinal = tempoAtual;
                proximoProcesso.TempoRestante = 0;

                AdicionarHistorico(tempoAtual, proximoProcesso.Nome, "Concluiu");
                concluidos.Add(proximoProcesso);
            }

            Processos = concluidos;
            CalcularMetricas();
        }
    }
}