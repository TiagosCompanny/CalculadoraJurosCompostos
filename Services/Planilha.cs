using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

namespace Abtrix.Services
{
    public class Planilha
    {   
        public Planilha()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Tabela");

                string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                workbook.SaveAs(desktopFolder + "\\PlanilhaJurosCompostos.xlsx");
            }
        }
        public void GerarTabelaJurosCompostos(decimal valorInicial, int periodoTotalMeses, decimal valorAporteMensal, decimal taxa)
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var workbook = new XLWorkbook(desktopFolder + "\\PlanilhaJurosCompostos.xlsx");
            
            //========================== PREENCHENDO DADOS ========================

            var worksheet = workbook.Worksheet("Tabela");
            worksheet.Cell("A1").Value = "Mês";
            worksheet.Cell("B1").Value = "Juros";
            worksheet.Cell("C1").Value = "Total Investido";
            worksheet.Cell("D1").Value = "Total Juros";
            worksheet.Cell("E1").Value = "Total Acumulado";

            decimal AcumulativoTotalInvestido = valorInicial;
            decimal TotalAcumulado = valorInicial;
            decimal AcumulativoRetroativoParaCalculoDeJuros = valorInicial;
            decimal acumulativoJuros = 0;
            worksheet.Cell("A2").Value = 0;
            worksheet.Cell("B2").Value = 0;
            worksheet.Cell("C2").Value = valorInicial;
            worksheet.Cell("D2").Value = acumulativoJuros;
            worksheet.Cell("E2").Value = TotalAcumulado;

            for (int mes = 1; mes <= periodoTotalMeses; mes++)
            {
                worksheet.Cell("A" + (2 + mes).ToString()).Value = mes;

                decimal juros = AcumulativoRetroativoParaCalculoDeJuros * taxa / 100;
                worksheet.Cell("B" + (2 + mes).ToString()).Value = juros;

                AcumulativoTotalInvestido += valorAporteMensal;
                worksheet.Cell("C" + (2 + mes).ToString()).Value = AcumulativoTotalInvestido;

                acumulativoJuros += juros;
                worksheet.Cell("D" + (2 + mes).ToString()).Value = acumulativoJuros;

                TotalAcumulado += juros + valorAporteMensal;
                worksheet.Cell("E" + (2 + mes).ToString()).Value = TotalAcumulado;

                AcumulativoRetroativoParaCalculoDeJuros += juros + valorAporteMensal;
            }

            //========================== FORMATAÇÃO ========================

            worksheet.Column(1).Width = 5; 
            worksheet.Column(2).Width = 20;
            worksheet.Column(3).Width = 20;
            worksheet.Column(4).Width = 20;
            worksheet.Column(5).Width = 20;

            worksheet.Range("A1:E" + periodoTotalMeses).Style.Border.SetTopBorder(XLBorderStyleValues.Thin).Border.SetRightBorder(XLBorderStyleValues.Thin).Border.SetBottomBorder(XLBorderStyleValues.Thin).Border.SetLeftBorder(XLBorderStyleValues.Thin);

            worksheet.Range("A1:E1").Style.Font.SetFontSize(12).Font.SetFontName("Arial");
            worksheet.Range("A1:E1").Style.Font.SetBold();
            worksheet.Range("A1:E1").Style.Fill.SetBackgroundColor(XLColor.Emerald);
            worksheet.Range("B2:E" + periodoTotalMeses + 2).Style.NumberFormat.Format = "0.00";
            foreach (var cell in worksheet.CellsUsed())
            {
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }
            worksheet.ShowGridLines = false;
            //==============================================================

            workbook.Save();
        }

        public void GerarGraficoJurosCompostos(int meses)
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(desktopFolder + "\\PlanilhaJurosCompostos.xlsx")))
            {
                var worksheetTabela = package.Workbook.Worksheets["Tabela"]; ;
                var worksheetGrafico = package.Workbook.Worksheets.Add("Grafico");
                int quantidadeDeLinhas = meses - 2;

                var chart = worksheetGrafico.Drawings.AddChart("Gráfico", eChartType.LineMarkers);
                chart.SetSize(1000, 450); // Defina o tamanho do gráfico
                chart.SetPosition(2, 0, 2, 0); // Defina a posição do gráfico na planilha 
                chart.Title.Text = "Gráfico de Evolução Patrimonial";

                chart.Series.Add(worksheetTabela.Cells["E2:E" + quantidadeDeLinhas], worksheetTabela.Cells["A2:A" + quantidadeDeLinhas]);
                chart.Series.Add(worksheetTabela.Cells["C2:C" + quantidadeDeLinhas], worksheetTabela.Cells["A2:A" + quantidadeDeLinhas]);


                package.Save();
            }
            var workbook = new XLWorkbook(desktopFolder + "\\PlanilhaJurosCompostos.xlsx");
            var worksheet = workbook.Worksheet("Grafico");
            worksheet.ShowGridLines = false;

            workbook.Save();
        }
    }
}
