using System.Collections.Generic;
using ProcessSchedulingSimulatorWinForms.Core;
using ProcessSchedulingSimulatorWinForms.Models;

namespace ProcessSchedulingSimulatorWinForms.Reporting
{
    public interface IReportWriter
    {
        void WriteReport(
            ResultadoSimulacao resultado,
            IEnumerable<Processo> processos,
            string caminhoArquivo
        );
    }
}