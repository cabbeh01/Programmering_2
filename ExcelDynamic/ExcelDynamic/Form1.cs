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
        Excel.Range[]  cell = new Excel.Range[3];
        dynamic[] temp = new dynamic[3];
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
            for(int i = 0; i<cell.Length; i++)
            {
                cell[i] = worksheet.Cells[int.Parse(tbxRow.Text), i+1];
            }

            cell[0].Value = tbxName.Text;
            cell[1].Value = tbxClass.Text;
            cell[2].Value = tbxCourse.Text;
            ClearValues();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            ClearValues();
            for (int i = 0; i < cell.Length; i++)
            {
                cell[i] = worksheet.Cells[int.Parse(tbxRow.Text), i + 1];
            }

            try
            {
                temp[0] = cell[0].Value;
                temp[1] = cell[1].Value;
                temp[2] = cell[2].Value;

                tbxName.AppendText(temp[0].ToString());
                tbxClass.AppendText(temp[1].ToString());
                tbxCourse.AppendText(temp[2].ToString());
            }
            catch(Exception err)
            {
                MessageBox.Show("Skriv in ett värde");
            }
            
        }

        private void ClearValues()
        {
            tbxName.Clear();
            tbxClass.Clear();
            tbxCourse.Clear();
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            worksheet.SaveAs("Test.xlsx");
            excel.Quit();
        }

    }
}
