using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormOrders : Form
    {
        static int valueColumns;
        string[] newColumNames = { "id", "Клієнт", "Промо-код", "Дата замовлення", "Статус", "Оплата", "Загальна ціна", "Створено", "Оновлено" };
        string[] oldColumnNames = { "id", "id_clients", "id_promo_codes", "date", "status", "payment", "total_cost", "created", "renovation" };
        public FormOrders()
        {
            DataBase database = new DataBase();
            InitializeComponent();
            valueColumns = (int)nudStr.Value;
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            DataTable tableData = database.GetTableData("orders", oldColumnNames, newColumNames, valueColumns);
            dataGridViewTable.DataSource = tableData;
            // Прибираємо рядок зліва
            dataGridViewTable.RowHeadersVisible = false;
            // Текст робимо по центру
            dataGridViewTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо по центру
            dataGridViewTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо жирним шрифтом
            dataGridViewTable.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // Розтягуємо данні в таблиці по всій ширині
            dataGridViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Виникає при зміні числа в numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudStr_ValueChanged_1(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            valueColumns = (int)nudStr.Value;
            DataTable tableData = database.GetTableData("orders", oldColumnNames, newColumNames, valueColumns);
            dataGridViewTable.DataSource = tableData;
        }
    }
}
