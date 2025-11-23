using ProcessSchedulingSimulatorWinForms.Algorithms;
using ProcessSchedulingSimulatorWinForms.Core;
using ProcessSchedulingSimulatorWinForms.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProcessSchedulingSimulatorWinForms
{
    public partial class Form1 : Form
    {
        private Simulador simulador;
        private ResultadoSimulacao resultadoAtual;

        public Form1()
        {
            InitializeComponent();
            simulador = new Simulador();
            InicializarDataGrids();
            InicializarComboBox();
            AtualizarBarraStatus();
        }

        private void InicializarDataGrids()
        {
            // Configurar DataGridView de processos
            dgvProcessos.AutoGenerateColumns = false;
            dgvProcessos.Columns.Clear();

            var colunas = new[]
            {
                new { Nome = "Id", Cabecalho = "ID", Largura = 50 },
                new { Nome = "Nome", Cabecalho = "Nome", Largura = 100 },
                new { Nome = "TempoChegada", Cabecalho = "Chegada", Largura = 80 },
                new { Nome = "TempoCPU", Cabecalho = "CPU", Largura = 80 },
                new { Nome = "Prioridade", Cabecalho = "Prioridade", Largura = 80 }
            };

            foreach (var coluna in colunas)
            {
                dgvProcessos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = coluna.Nome,
                    HeaderText = coluna.Cabecalho,
                    DataPropertyName = coluna.Nome,
                    Width = coluna.Largura
                });
            }

            // Configurar DataGridView de comparação
            dgvComparacao.AutoGenerateColumns = false;
            dgvComparacao.Columns.Clear();

            var colunasComparacao = new[]
            {
                new { Nome = "Algoritmo", Cabecalho = "Algoritmo", Largura = 200 },
                new { Nome = "EsperaMedio", Cabecalho = "Espera Médio", Largura = 120 },
                new { Nome = "RetornoMedio", Cabecalho = "Retorno Médio", Largura = 120 },
                new { Nome = "Vazao", Cabecalho = "Vazão", Largura = 100 },
                new { Nome = "TempoTotal", Cabecalho = "Tempo Total", Largura = 100 }
            };

            foreach (var coluna in colunasComparacao)
            {
                dgvComparacao.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = coluna.Nome,
                    HeaderText = coluna.Cabecalho,
                    DataPropertyName = coluna.Nome,
                    Width = coluna.Largura
                });
            }
        }

        private void InicializarComboBox()
        {
            cmbAlgoritmo.Items.AddRange(new string[] {
                "FCFS (Primeiro a Chegar, Primeiro a Ser Servido)",
                "SJF (Trabalho Mais Curto Primeiro)",
                "Round Robin (Quantum: 2)",
                "Round Robin (Quantum: 3)"
            });
            cmbAlgoritmo.SelectedIndex = 0;
        }

        private void AtualizarBarraStatus()
        {
            lblQuantidadeProcessos.Text = simulador.QuantidadeProcessos.ToString();
        }

        private void BtnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeProcesso.Text))
                {
                    MessageBox.Show("Por favor, insira um nome para o processo.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var processo = new Processo(
                    simulador.QuantidadeProcessos + 1,
                    txtNomeProcesso.Text,
                    (int)numTempoChegada.Value,
                    (int)numTempoCPU.Value,
                    (int)numPrioridade.Value
                );

                simulador.AdicionarProcesso(processo);
                AtualizarGridProcessos();
                LimparFormularioProcesso();
                AtualizarBarraStatus();

                MessageBox.Show("Processo adicionado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar processo: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGerarAleatorios_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = (int)numQuantidade.Value;
                if (quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser maior que zero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                simulador.GerarProcessosAleatorios(quantidade);
                AtualizarGridProcessos();
                AtualizarBarraStatus();

                MessageBox.Show($"{quantidade} processos gerados com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar processos: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimparProcessos_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja limpar todos os processos?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                simulador.LimparProcessos();
                AtualizarGridProcessos();
                AtualizarBarraStatus();
            }
        }

        private void BtnExecutarSimulacao_Click(object sender, EventArgs e)
        {
            if (simulador.QuantidadeProcessos == 0)
            {
                MessageBox.Show("Nenhum processo definido. Adicione processos antes de executar a simulação.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnExecutarSimulacao.Enabled = false;

                resultadoAtual = simulador.ExecutarSimulacao();
                ExibirResultados();
                tabControl1.SelectedTab = tabPageResults;

                MessageBox.Show("Simulação executada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante a simulação: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnExecutarSimulacao.Enabled = true;
            }
        }

        private void CmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultadoAtual?.Algoritmos == null || cmbAlgoritmo.SelectedIndex < 0)
                return;

            var algoritmoSelecionado = resultadoAtual.Algoritmos[cmbAlgoritmo.SelectedIndex];
            ExibirDetalhesAlgoritmo(algoritmoSelecionado);
        }

        private void ExibirResultados()
        {
            // Preencher comparação
            var dadosComparacao = new List<object>();
            foreach (var algoritmo in resultadoAtual.Algoritmos)
            {
                dadosComparacao.Add(new
                {
                    Algoritmo = algoritmo.Nome,
                    EsperaMedio = algoritmo.MetricasSimulacao.TempoEsperaMedio.ToString("F2"),
                    RetornoMedio = algoritmo.MetricasSimulacao.TempoRetornoMedio.ToString("F2"),
                    Vazao = algoritmo.MetricasSimulacao.Vazao.ToString("F3"),
                    TempoTotal = algoritmo.MetricasSimulacao.TempoExecucaoTotal.ToString()
                });
            }

            dgvComparacao.DataSource = dadosComparacao;

            // Exibir detalhes do primeiro algoritmo
            if (resultadoAtual.Algoritmos.Count > 0)
            {
                ExibirDetalhesAlgoritmo(resultadoAtual.Algoritmos[0]);
            }
        }

        private void ExibirDetalhesAlgoritmo(AlgoritmoEscalonamento algoritmo)
        {
            // Atualizar histórico de execução
            lstHistoricoExecucao.Items.Clear();
            lstHistoricoExecucao.Items.Add("Tempo | Processo | Ação");
            lstHistoricoExecucao.Items.AddRange(algoritmo.HistoricoExecucao.ToArray());

            // Atualizar métricas
            lblMetricas.Text = $"=== {algoritmo.Nome} ===\n\n" +
                            algoritmo.MetricasSimulacao.ObterMetricasFormatadas();
        }

        private void AtualizarGridProcessos()
        {
            dgvProcessos.DataSource = null;
            dgvProcessos.DataSource = simulador.ObterProcessos();
            dgvProcessos.Refresh();
        }

        private void LimparFormularioProcesso()
        {
            txtNomeProcesso.Clear();
            numTempoChegada.Value = 0;
            numTempoCPU.Value = 1;
            numPrioridade.Value = 1;
        }

        private void BtnSalvarRelatorio_Click(object sender, EventArgs e)
        {
            if (resultadoAtual == null)
            {
                MessageBox.Show("Execute uma simulação antes de salvar o relatório.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog dialogoSalvar = new SaveFileDialog())
            {
                dialogoSalvar.Filter = "Arquivo de Texto (*.txt)|*.txt";
                dialogoSalvar.Title = "Salvar Relatório";
                dialogoSalvar.FileName = $"relatorio_simulacao_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (dialogoSalvar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter escritor = new StreamWriter(dialogoSalvar.FileName))
                        {
                            escritor.WriteLine("RELATÓRIO DE SIMULAÇÃO DE ESCALONAMENTO");
                            escritor.WriteLine($"Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                            escritor.WriteLine($"Número de processos: {resultadoAtual.QuantidadeProcessos}");
                            escritor.WriteLine();
                            escritor.WriteLine("PROCESSOS:");
                            escritor.WriteLine("ID | Nome | Chegada | CPU | Prioridade");

                            foreach (var processo in simulador.ObterProcessos())
                            {
                                escritor.WriteLine($"{processo.Id} | {processo.Nome} | {processo.TempoChegada} | {processo.TempoCPU} | {processo.Prioridade}");
                            }

                            escritor.WriteLine();
                            escritor.WriteLine("COMPARAÇÃO ENTRE ALGORITMOS:");
                            escritor.WriteLine("Algoritmo | Espera Médio | Retorno Médio | Vazão | Tempo Total");

                            foreach (var algoritmo in resultadoAtual.Algoritmos)
                            {
                                escritor.WriteLine($"{algoritmo.Nome} | " +
                                    $"{algoritmo.MetricasSimulacao.TempoEsperaMedio:F2} | " +
                                    $"{algoritmo.MetricasSimulacao.TempoRetornoMedio:F2} | " +
                                    $"{algoritmo.MetricasSimulacao.Vazao:F3} | " +
                                    $"{algoritmo.MetricasSimulacao.TempoExecucaoTotal}");
                            }

                            // Encontrar melhores algoritmos
                            var melhorEspera = resultadoAtual.Algoritmos
                                .OrderBy(a => a.MetricasSimulacao.TempoEsperaMedio).First();
                            var melhorRetorno = resultadoAtual.Algoritmos
                                .OrderBy(a => a.MetricasSimulacao.TempoRetornoMedio).First();
                            var melhorVazao = resultadoAtual.Algoritmos
                                .OrderByDescending(a => a.MetricasSimulacao.Vazao).First();

                            escritor.WriteLine();
                            escritor.WriteLine("ANÁLISE COMPARATIVA:");
                            escritor.WriteLine($"Melhor para tempo de espera: {melhorEspera.Nome} ({melhorEspera.MetricasSimulacao.TempoEsperaMedio:F2})");
                            escritor.WriteLine($"Melhor para tempo de retorno: {melhorRetorno.Nome} ({melhorRetorno.MetricasSimulacao.TempoRetornoMedio:F2})");
                            escritor.WriteLine($"Melhor para vazão: {melhorVazao.Nome} ({melhorVazao.MetricasSimulacao.Vazao:F3})");
                        }

                        MessageBox.Show("Relatório salvo com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar relatório: {ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNomeProcesso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}