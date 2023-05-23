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
    public partial class FormInsertGoods : Form
    {
        DataBase database = new DataBase();
        public FormInsertGoods()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.FromArgb(34, 33, 74);
            List<string> warehouseNames = database.GetWarehouseNames();
            List<string> prodSupplierNames = database.GetSupplierNames();
            List<string> activeDiscounts = database.GetActiveDiscounts();
            List<string> tagNames = database.GetTagNames();
            List<string> categoryNames = database.GetCategoryNames();
            comboBox_warehouses.DataSource = warehouseNames;
            comboBox_prod_suppliers.DataSource = prodSupplierNames;
            comboBox_discounts.DataSource = activeDiscounts;
            comboBox_tags.DataSource = tagNames;
            comboBox_prod_category.DataSource = categoryNames;
        }
        /// <summary>
        /// Внесеня данних в таблицю Goods по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int IndexShift = 1; // Погрешность +1 к index в базе данных
            int id_warehouses = comboBox_warehouses.SelectedIndex;
            int id_prod_suppliers = comboBox_prod_suppliers.SelectedIndex;
            int id_discounts = comboBox_discounts.SelectedIndex;
            int id_tags = comboBox_tags.SelectedIndex;
            int id_prod_category = comboBox_prod_category.SelectedIndex;
            string name = textBox_Name.Text;
            List<string> goodNames = database.GetGoodNames();

            if (goodNames.Contains(name))
            {
                MessageBox.Show("Помилка: Товар із таким ім'ям уже існує.");
            }
            else
            {
                string description = textBox_Description.Text;
                decimal price;
                if (decimal.TryParse(textBox_Price.Text, out price) && price > 0)
                {
                    database.AddGoods(id_warehouses + IndexShift, id_prod_suppliers + IndexShift, id_discounts + IndexShift, id_tags + IndexShift, id_prod_category + IndexShift, name, description, price);
                    MessageBox.Show("Товар успішно додано.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Виникла помилка. Ціна повинна мати число більше нуля.");
                }
            }

        }
    }
}
