using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelDynamic
{
    public partial class Form1 : Form
    {
        Excel.Application excel;
        Excel.Worksheet worksheet;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            excel = new Excel.Application();
            excel.Visible = true;

            excel.Workbooks.Add();
            worksheet = excel.ActiveSheet;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Excel.Range cell = worksheet.Cells[int.Parse(tbxRow.Text), "A"];
            cell.Value = tbxName.Text;
        }
    }
}
