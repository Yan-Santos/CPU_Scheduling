namespace ProcessSchedulingSimulatorWinForms.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TempoChegada { get; set; }
        public int TempoCPU { get; set; }
        public int TempoRestante { get; set; }
        public int Prioridade { get; set; }
        public int TempoInicio { get; set; }
        public int TempoFinal { get; set; }
        public int TempoEspera { get; set; }
        public int TempoRetorno { get; set; }

        public Processo(int id, string nome, int tempoChegada, int tempoCPU, int prioridade = 1)
        {
            Id = id;
            Nome = nome;
            TempoChegada = tempoChegada;
            TempoCPU = tempoCPU;
            TempoRestante = tempoCPU;
            Prioridade = prioridade;
            TempoInicio = -1;
        }

        public Processo Clonar()
        {
            return new Processo(Id, Nome, TempoChegada, TempoCPU, Prioridade)
            {
                TempoInicio = TempoInicio,
                TempoFinal = TempoFinal,
                TempoEspera = TempoEspera,
                TempoRetorno = TempoRetorno,
                TempoRestante = TempoRestante
            };
        }
    }
}