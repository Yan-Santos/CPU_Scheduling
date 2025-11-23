using ProcessSchedulingSimulatorWinForms.Algorithms;
using ProcessSchedulingSimulatorWinForms.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessSchedulingSimulatorWinForms.Core
{
    public class Simulador
    {
        private List<Processo> processos;
        private List<AlgoritmoEscalonamento> algoritmos;

        public Simulador()
        {
            processos = new List<Processo>();
            algoritmos = new List<AlgoritmoEscalonamento>();
        }

        public void AdicionarProcesso(Processo processo)
        {
            processos.Add(processo);
        }

        public void GerarProcessosAleatorios(int quantidade, int tempoChegadaMaximo = 10, int tempoCPUMaximo = 10)
        {
            Random rand = new Random();
            processos.Clear();

            for (int i = 0; i < quantidade; i++)
            {
                processos.Add(new Processo(
                    i + 1,
                    $"P{i + 1}",
                    rand.Next(0, tempoChegadaMaximo + 1),
                    rand.Next(1, tempoCPUMaximo + 1),
                    rand.Next(1, 5)
                ));
            }
        }

        public ResultadoSimulacao ExecutarSimulacao()
        {
            algoritmos.Clear();

            algoritmos.Add(new FCFS { Processos = CopiarProcessos() });
            algoritmos.Add(new SJF { Processos = CopiarProcessos() });
            algoritmos.Add(new RoundRobin(2) { Processos = CopiarProcessos() });
            algoritmos.Add(new RoundRobin(3) { Processos = CopiarProcessos() });

            foreach (var algoritmo in algoritmos)
            {
                algoritmo.Executar();
            }

            return new ResultadoSimulacao
            {
                Algoritmos = algoritmos,
                QuantidadeProcessos = processos.Count
            };
        }

        private List<Processo> CopiarProcessos()
        {
            return processos.Select(p => p.Clonar()).ToList();
        }

        public void LimparProcessos()
        {
            processos.Clear();
        }

        public List<Processo> ObterProcessos() => processos;
        public int QuantidadeProcessos => processos.Count;
    }

    public class ResultadoSimulacao
    {
        public List<AlgoritmoEscalonamento> Algoritmos { get; set; }
        public int QuantidadeProcessos { get; set; }
    }
}