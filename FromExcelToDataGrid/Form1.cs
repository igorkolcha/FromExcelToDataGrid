using ClosedXML;
using ClosedXML.Excel;
using System.Data;

namespace FromExcelToDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.WindowState = FormWindowState.Maximized;
            this.DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;          
        }

        private void SelectExcelDownloadDataGrid_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Select Excel file";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    DataTable dt = LoadExcelToDataTable(filePath);
                    DataGrid.DataSource = dt;
                    //DataGrid.Columns[0].Visible = false;
                }
            }
        }

        private DataTable LoadExcelToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // first sheet
                bool firstRow = true;

                foreach (var row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        // headlines
                        foreach (var cell in row.CellsUsed())
                            dt.Columns.Add(cell.Value.ToString());
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (var cell in row.Cells(1, dt.Columns.Count))
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
            }

            return dt;
        }
    }
}
