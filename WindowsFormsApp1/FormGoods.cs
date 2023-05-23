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

    public partial class FormGoods : Form
    {
        private void ReloadData()
        {
            DataBase database = new DataBase();
            valueColumns = (int)nudStr.Value;
            DataTable tableData = database.GetTableData("goods", oldColumnNames, newColumNames, valueColumns, searchName);
            dataGridViewTable.DataSource = tableData;
        }
        static string searchName;
        static int valueColumns;
        string[] newColumNames = { "id", "Склад", "Постачальник", "Знижка", "Мітка", "Категорія", "Назва", "Опис", "Ціна", "Створено", "Оновлено" };
        string[] oldColumnNames = { "id", "id_warehouses", "id_prod_suppliers", "id_discounts", "id_tags", "id_prod_category", "name", "description", "price", "created", "renovation" };
        public FormGoods()
        {
         
            DataBase database = new DataBase();
            InitializeComponent();
            KeyPreview = true; // Включаем просмотр клавиш на форме
            KeyDown += FormGoods_KeyDown; // Привязываем обработчик события KeyDown к форме
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelMenu.BackColor = Color.FromArgb(34, 33, 74);
            DataTable tableData = database.GetTableData("goods", oldColumnNames, newColumNames, valueColumns);
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
        private void nudStr_ValueChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
        /// <summary>
        /// Відкритя форми з вставкою Товару до Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new FormInsertGoods();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            this.Activate();
            ReloadData();
        }
        /// <summary>
        /// Пошук при натиску на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Find_Click(object sender, EventArgs e)
        {
            searchName = textBox_Find.Text;
            searchName = textBox_Find.Text.Replace("'", "\\'");
            ReloadData();
        }
        /// <summary>
        /// Визов пошуку при натиску на Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGoods_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Предотвращаем воспроизведение системного звука
                // Проверяем, какая кнопка должна быть вызвана
                if (ActiveControl == textBox_Find) // Замените textBox_Find на ваш TextBox
                {
                    // Вызываем определенную кнопку
                    btn_Find.PerformClick(); // Замените button_Search на вашу кнопку
                }
            }
        }
        /// <summary>
        /// Відкритя форми з видаленням Товару з Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new FormDeleteGoods();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            this.Activate();
            ReloadData();
        }
        /// <summary>
        /// Відкриття форми зі змінною данних в таблиці
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new FormUpdateGoods();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            this.Activate();
            ReloadData();
        }
    }
}
