using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138
{
    class ReportGenerator
    {

        private readonly string _reportTitle;
        private readonly string _filePath;
        private readonly DataGridView _dataGridView;
        private readonly DataTable _dataTable;

        public ReportGenerator(string reportTitle, string filePath, DataGridView dataGridView)
        {
            _reportTitle = reportTitle;
            _filePath = filePath;
            _dataGridView = dataGridView;
        }
        public ReportGenerator(string reportTitle, string filePath, DataTable dataTable)
        {
            _reportTitle = reportTitle;
            _filePath = filePath;
            _dataTable = dataTable;
        }

        public void GenerateReport()
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(_filePath, FileMode.Create));

            document.Open();

            AddReportTitle(document);
            AddGeneralInfo(document);
            AddTable(document);

            document.Close();
            MessageBox.Show("Downloaded Successfully", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddReportTitle(Document document)
        {
            PdfPTable headingTable = new PdfPTable(1);
            headingTable.WidthPercentage = 100;

            PdfPCell headingCell = new PdfPCell(new Phrase(_reportTitle, GetTitleFont()));
            headingCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headingCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headingCell.Padding = 8;
            headingCell.BackgroundColor = BaseColor.BLACK;
            headingTable.AddCell(headingCell);

            document.Add(headingTable);
        }
        public void AddGeneralInfo(Document document)
        {
            Paragraph additionalInfo = new Paragraph();
            additionalInfo.Alignment = Element.ALIGN_LEFT;
            additionalInfo.Add(new Chunk("\nCourse:   ", new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.BOLD, BaseColor.BLACK)));
            additionalInfo.Add(new Chunk("CS-262L Database", new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.BLACK)));
            additionalInfo.Add(new Chunk("\nSemester:   ", new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.BOLD, BaseColor.BLACK)));
            additionalInfo.Add(new Chunk("Spring 2024", new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.BLACK)));
            additionalInfo.Add(new Chunk("\nLecturer:   ", new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.BOLD, BaseColor.BLACK)));
            additionalInfo.Add(new Chunk("Nazeef ul Haq\n\n", new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.BLACK)));
            document.Add(additionalInfo);
        }
        private void AddTable(Document document)
        {
            PdfPTable table = null;
            if (_dataGridView != null)
            {
                table = new PdfPTable(_dataGridView.ColumnCount);
                table.WidthPercentage = 100f;
                AddTableOnGrid(ref table);
            }
            else if (_dataTable != null)
            {
                table = new PdfPTable(_dataTable.Columns.Count);
                table.WidthPercentage = 100f;
                AddTableOnDt(ref table);
            }

            if (table != null)
                document.Add(table);
        }

        private void AddTableOnGrid(ref PdfPTable table)
        {
            // Add the column headers to the table

            for (int i = 0; i < _dataGridView.ColumnCount; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(_dataGridView.Columns[i].HeaderText, GetHeaderFont()));
                cell.BackgroundColor = BaseColor.BLACK;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 8;
                table.AddCell(cell);
            }

            // Add the rows to the table
            for (int i = 0; i < _dataGridView.RowCount; i++)
            {
                for (int j = 0; j < _dataGridView.ColumnCount; j++)
                {
                    if (_dataGridView[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(_dataGridView[j, i].Value.ToString(), GetNormalFont()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.Padding = 8;
                        table.AddCell(cell);
                    }
                }
            }
        }

        private void AddTableOnDt(ref PdfPTable table)
        {
            // Add the column headers to the table

            // Add header cells
            foreach (DataColumn column in _dataTable.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(cell);
            }

            // Add data cells
            foreach (DataRow row in _dataTable.Rows)
            {
                foreach (DataColumn column in _dataTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(row[column].ToString()));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                }
            }
        }


        private Font GetTitleFont()
        {
            return new Font(Font.FontFamily.TIMES_ROMAN, 16, Font.BOLD, BaseColor.WHITE);
        }

        private Font GetHeaderFont()
        {
            return new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD, BaseColor.WHITE);
        }

        private Font GetNormalFont()
        {
            return new Font(Font.FontFamily.TIMES_ROMAN, 10, Font.NORMAL, BaseColor.BLACK);
        }
    }
}
