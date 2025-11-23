using ProcessSchedulingSimulatorWinForms.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessSchedulingSimulatorWinForms.Algorithms
{
    public class RoundRobin : AlgoritmoEscalonamento
    {
        public int Quantum { get; set; }

        public RoundRobin(int quantum = 2)
        {
            Nome = $"Round Robin (Quantum: {quantum})";
            Quantum = quantum;
        }

        public override void Executar()
        {
            HistoricoExecucao.Clear();

            var processos = Processos.Select(p => p.Clonar()).ToList();
            var fila = new Queue<Processo>();
            var concluidos = new List<Processo>();
            int tempoAtual = 0;

            processos = processos.OrderBy(p => p.TempoChegada).ToList();

            while (processos.Count > 0 || fila.Count > 0)
            {
                var chegando = processos.Where(p => p.TempoChegada <= tempoAtual).ToList();
                foreach (var processo in chegando)
                {
                    fila.Enqueue(processo);
                    processos.Remove(processo);
                }

                if (fila.Count == 0)
                {
                    tempoAtual++;
                    continue;
                }

                var processoAtual = fila.Dequeue();

                if (processoAtual.TempoInicio == -1)
                {
                    processoAtual.TempoInicio = tempoAtual;
                    AdicionarHistorico(tempoAtual, processoAtual.Nome, "Iniciou");
                }

                int fatiaTempo = System.Math.Min(Quantum, processoAtual.TempoRestante);
                processoAtual.TempoRestante -= fatiaTempo;
                tempoAtual += fatiaTempo;

                var novasChegadas = processos.Where(p => p.TempoChegada <= tempoAtual).ToList();
                foreach (var processo in novasChegadas)
                {
                    fila.Enqueue(processo);
                    processos.Remove(processo);
                }

                if (processoAtual.TempoRestante > 0)
                {
                    AdicionarHistorico(tempoAtual, processoAtual.Nome, $"Pausou (Restante: {processoAtual.TempoRestante})");
                    fila.Enqueue(processoAtual);
                }
                else
                {
                    processoAtual.TempoFinal = tempoAtual;
                    AdicionarHistorico(tempoAtual, processoAtual.Nome, "Concluiu");
                    concluidos.Add(processoAtual);
                }
            }

            Processos = concluidos;
            CalcularMetricas();
        }
    }
}