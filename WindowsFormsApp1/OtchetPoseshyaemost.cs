using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class OtchetPoseshyaemost : Form
    {
        public OtchetPoseshyaemost()
        {
            InitializeComponent();
        }

        private void OtchetPoseshyaemost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Poseshaemost". При необходимости она может быть перемещена или удалена.
            this.poseshaemostTableAdapter.Fill(this.dataSet1.Poseshaemost);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls; *.xlsx"; // Отображаютя только файлы Excel
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Если пользователь сохранил документ
            {
                // Создание Excel документа
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // Создание новой рабочей книги в этом документе
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // Создание нового листа в вышесозданной книге
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // Устанавливает свойство видимости документа за программой. Можно установить false
                app.Visible = true;
                worksheet = workbook.ActiveSheet; // Определение значения объекта
                worksheet.Name = "Отчет Посещаемость"; // Изменение имени рабочего листа
                // Заполнение Excel документа
                worksheet.Cells[1, 1] = "Отчет Посещаемость:";
                worksheet.Cells[2, 1] = "id посещаемости";
                worksheet.Cells[2, 2] = "Фамилия студента";
                worksheet.Cells[2, 3] = "id занятия";
                worksheet.Cells[2, 4] = "Дата и время занятия";
                worksheet.Cells[2, 5] = "Присутствие";

                for (int i = 1; i < poseshaemostDataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Columns[i].ColumnWidth = 30;//Установление ширины столбцов
                    worksheet.Cells[3, i].Font.Color = Color.Red;//Установление цвета шрифта столбцов
                    worksheet.Cells[3, i] = poseshaemostDataGridView[i - 1, 0].Value;

                }

                for (int i = 1; i < poseshaemostDataGridView.RowCount; i++)
                    for (int j = 0; j < poseshaemostDataGridView.ColumnCount; j++)
                    { worksheet.Cells[i + 3, j + 1] = poseshaemostDataGridView[j, i].Value; }
                // Сохраняет документ
                workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit(); // Закрывает документ
            }
        }
    }
}
