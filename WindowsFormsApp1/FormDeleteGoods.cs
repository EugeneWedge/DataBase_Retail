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
    public partial class FormDeleteGoods : Form
    {
        List<string> goodsNames;
        DataBase database = new DataBase();
        public FormDeleteGoods()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.FromArgb(34, 33, 74);
            List<string> categoryNames = database.GetCategoryNames();
            // Додаємо пусту строку до початку списку категорій
            List<string> categoryNamesWithEmpty = new List<string> { "Всі категорії" };
            categoryNamesWithEmpty.AddRange(categoryNames);
            // Прив'язуємо джерело даних з пустою строкою до ComboBox
            comboBox_prod_category.DataSource = categoryNamesWithEmpty;
            goodsNames = database.GetProductNamesByCategory();
            comboBox_NameGoods.DataSource = goodsNames;
        }
        /// <summary>
        /// Зміна категорії пошуку товару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_prod_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_prod_category.SelectedIndex > 0)
            {
                goodsNames = database.GetProductNamesByCategory(comboBox_prod_category.SelectedIndex);
                comboBox_NameGoods.DataSource = goodsNames;
            }
            else
            {
                goodsNames = database.GetProductNamesByCategory();
                comboBox_NameGoods.DataSource = goodsNames;
            }
        }
        /// <summary>
        /// Видалення товару по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox_NameGoods.SelectedItem.ToString();
            string[] parts = selectedValue.Split('-');

            if (parts.Length == 2)
            {
                int productId;
                if (int.TryParse(parts[0].Trim(), out productId))
                {
                    string productName = parts[1].Trim();

                    DialogResult result = MessageBox.Show("Дійсно ви хочете видалити товар - " + productName + "?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        database.DeleteProduct(productId);
                        this.Close();
                    }
                }
            }
        }
    }
}
