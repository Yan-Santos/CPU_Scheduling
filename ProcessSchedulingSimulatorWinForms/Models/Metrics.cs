namespace ProcessSchedulingSimulatorWinForms.Models
{
    public class Metricas
    {
        public double TempoEsperaMedio { get; set; }
        public double TempoRetornoMedio { get; set; }
        public double TempoRespostaMedio { get; set; }
        public double Vazao { get; set; }
        public int TempoExecucaoTotal { get; set; }

        public string ObterMetricasFormatadas()
        {
            return $"Tempo médio de espera: {TempoEsperaMedio:F2} unidades\n" +
                   $"Tempo médio de retorno: {TempoRetornoMedio:F2} unidades\n" +
                   $"Tempo médio de resposta: {TempoRespostaMedio:F2} unidades\n" +
                   $"Vazão: {Vazao:F3} processos/unidade\n" +
                   $"Tempo total de execução: {TempoExecucaoTotal} unidades";
        }
    }
}