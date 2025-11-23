using ProcessSchedulingSimulatorWinForms.Models;
using System.Diagnostics;
using System.Linq;

namespace ProcessSchedulingSimulatorWinForms.Algorithms
{
    public class FCFS : AlgoritmoEscalonamento
    {
        public FCFS()
        {
            Nome = "FCFS (Primeiro a Chegar, Primeiro a Ser Servido)";
        }

        public override void Executar()
        {
            HistoricoExecucao.Clear();

            if (Processos.Count == 0) return;

            var filaProntos = Processos.OrderBy(p => p.TempoChegada).ToList();
            int tempoAtual = 0;

            foreach (var processo in filaProntos)
            {
                if (tempoAtual < processo.TempoChegada)
                    tempoAtual = processo.TempoChegada;

                processo.TempoInicio = tempoAtual;
                AdicionarHistorico(tempoAtual, processo.Nome, "Iniciou");

                tempoAtual += processo.TempoCPU;
                processo.TempoFinal = tempoAtual;
                processo.TempoRestante = 0;

                AdicionarHistorico(tempoAtual, processo.Nome, "Concluiu");
            }

            CalcularMetricas();
        }
    }
}