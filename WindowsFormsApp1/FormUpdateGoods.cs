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
    public partial class FormUpdateGoods : Form
    {
        DataBase database = new DataBase();
        List<string> goodsNames;
        public FormUpdateGoods()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.FromArgb(34, 33, 74);
            List<string> category = database.GetCategoryNames();
            // Додаємо пусту строку до початку списку категорій
            List<string> categoryNamesWithEmpty = new List<string> { "Всі категорії" };
            categoryNamesWithEmpty.AddRange(category);
            // Прив'язуємо джерело даних з пустою строкою до ComboBox
            comboBox_category.DataSource = categoryNamesWithEmpty;
            goodsNames = database.GetProductNamesByCategory();
            comboBox_NameGoods.DataSource = goodsNames;

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
        /// Зміна данних в товарі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox_NameGoods.SelectedItem.ToString();
            string[] parts = selectedValue.Split('-');

            if (parts.Length == 2)
            {
                int productId;
                if (int.TryParse(parts[0].Trim(), out productId))
                {
                    string productName = parts[1].Trim();

                    DialogResult result = MessageBox.Show("Дійсно ви хочете змінити товар - " + productName + "?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int IndexShift = 1; // Погрешность +1 к index в базе данных
                        int id_warehouses = comboBox_warehouses.SelectedIndex;
                        int id_prod_suppliers = comboBox_prod_suppliers.SelectedIndex;
                        int id_discounts = comboBox_discounts.SelectedIndex;
                        int id_tags = comboBox_tags.SelectedIndex;
                        int id_prod_category = comboBox_prod_category.SelectedIndex;
                        string name = textBox_Name.Text;
                        List<string> goodNames = database.GetGoodNames();
                            string description = textBox_Description.Text;
                            decimal price;
                            if (decimal.TryParse(textBox_Price.Text, out price) && price > 0)
                            {
                                database.UpdateGoods(productId, id_warehouses + IndexShift, id_prod_suppliers + IndexShift, id_discounts + IndexShift, id_tags + IndexShift, id_prod_category + IndexShift, name, description, price);
                                MessageBox.Show("Товар успішно змінено.");
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
        /// <summary>
        /// Зміна категорії пошуку товару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedIndex > 0)
            {
                goodsNames = database.GetProductNamesByCategory(comboBox_category.SelectedIndex);
                comboBox_NameGoods.DataSource = goodsNames;
            }
            else
            {
                goodsNames = database.GetProductNamesByCategory();
                comboBox_NameGoods.DataSource = goodsNames;
            }
        }
    }
}
