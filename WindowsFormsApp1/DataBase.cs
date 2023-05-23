using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DataBase
{
        static string mySqlconnection = "server=127.0.0.1; user=root; database=retail_db; password=";
        MySqlConnection sqlConnection = new MySqlConnection(mySqlconnection);
        /// <summary>
        /// Відкитя підключення к базі даних
        /// </summary>
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        // =======================================================================================
        /// <summary>
        /// Зміна данних в існуючому товарі
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idWarehouse"></param>
        /// <param name="idProdSupplier"></param>
        /// <param name="idDiscount"></param>
        /// <param name="idTag"></param>
        /// <param name="idProdCategory"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        public void UpdateGoods(int id, int idWarehouse, int idProdSupplier, int idDiscount, int idTag, int idProdCategory, string name, string description, decimal price)
        {
            try
            {
                openConnection();

                string query = "UPDATE goods SET id_warehouses = @idWarehouse, id_prod_suppliers = @idProdSupplier, id_discounts = @idDiscount, id_tags = @idTag, " +
                               "id_prod_category = @idProdCategory, name = @name, description = @description, price = @price, renovation = @renovation " +
                               "WHERE id = @id";

                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idWarehouse", idWarehouse);
                command.Parameters.AddWithValue("@idProdSupplier", idProdSupplier);
                command.Parameters.AddWithValue("@idDiscount", idDiscount);
                command.Parameters.AddWithValue("@idTag", idTag);
                command.Parameters.AddWithValue("@idProdCategory", idProdCategory);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@renovation", DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при обновлении записи в таблице 'goods': " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        // =======================================================================================
        /// <summary>
        /// Видалення товару з таблиці Goods
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProduct(int productId)
        {
            try
            {
                openConnection();

                string query = "DELETE FROM goods WHERE id = @productId";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@productId", productId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Товар успішно видалено.");
                }
                else
                {
                    MessageBox.Show("Товар з вказаним ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні товару: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        // =======================================================================================
        /// <summary>
        /// Отримання списку товарів по категорії
        /// </summary>
        /// <param name="id_prod_category"></param>
        /// <returns></returns>
        public List<string> GetProductNamesByCategory(int? id_prod_category = null)
        {
            List<string> productNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT id, name FROM goods";

                if (id_prod_category != null)
                {
                    query += " WHERE id_prod_category = @category";
                }

                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                if (id_prod_category != null)
                {
                    command.Parameters.AddWithValue("@category", id_prod_category);
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        string formattedName = id + " - " + name;
                        productNames.Add(formattedName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при отриманні списку товарів за категорією: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return productNames;
        }


        /// <summary>
        /// Отримання списку поставників з таблиці prod_suppliers
        /// </summary>
        /// <returns></returns>
        public List<string> GetSupplierNames()
        {
            List<string> supplierNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name FROM prod_suppliers";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        supplierNames.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка поставщиков: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return supplierNames;
        }

        /// <summary>
        /// Отриманя списку категорій з таблиці prod_category
        /// </summary>
        /// <returns></returns>
        public List<string> GetCategoryNames()
        {
            List<string> categoryNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name FROM prod_category";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        categoryNames.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка категорий: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return categoryNames;
        }
        /// <summary>
        /// Отримуємо спискок знижок з таблиці discounts
        /// </summary>
        /// <returns></returns>
        /// <summary>
        public List<string> GetActiveDiscounts()
        {
            List<string> activeDiscounts = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name, percent FROM discounts WHERE start_date <= CURDATE() AND end_date >= CURDATE()";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        int percent = reader.GetInt32("percent");
                        string discountString = $"{name} - {percent}%";
                        activeDiscounts.Add(discountString);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка активных скидок: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return activeDiscounts;
        }
        /// <summary>
        /// Отримаємо список Товарів
        /// </summary>
        /// <returns></returns>
        public List<string> GetGoodNames()
        {
            List<string> goodNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name FROM goods";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        goodNames.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении списка товаров: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return goodNames;
        }
        /// <summary>
        /// Отримання тегів для товарів з таблиці tags
        /// </summary>
        /// <returns></returns>
        public List<string> GetTagNames()
        {
            List<string> tagNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name FROM tags";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        tagNames.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка тегов: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return tagNames;
        }

        /// <summary>
        /// Отриманя списку складів з таблиці warehouses
        /// </summary>
        /// <returns></returns>
        public List<string> GetWarehouseNames()
        {
            List<string> warehouseNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT name FROM warehouses";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        warehouseNames.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка складов: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return warehouseNames;
        }
        // =======================================================================================
        /// <summary>
        /// Вивод таблиць на DataGridView
        /// </summary>
        /// <param name="tableName">Назва таблицы</param>
        /// <param name="oldColumnNames">Старі назви колонок</param>
        /// <param name="newColumnNames">Нові назви колонок</param>
        /// <param name="numRows">Кількість строк що треба вивести</param>
        /// <returns></returns>
        public DataTable GetTableData(string tableName, string[] oldColumnNames, string[] newColumnNames, int numRows = -1, string searchName = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                openConnection();

                string query = "SELECT ";

                for (int i = 0; i < oldColumnNames.Length; i++)
                {
                    string oldColumnName = oldColumnNames[i];
                    string newColumnName = newColumnNames[i];

                    // Handle special cases for joining other tables
                    if (oldColumnName.StartsWith("id_"))
                    {
                        string referencedTableName = oldColumnName.Substring(3);  // Remove "id_" prefix
                        query += $"{referencedTableName}.name AS `{newColumnName}`, ";
                    }
                    else
                    {
                        query += $"g.`{oldColumnName}` AS `{newColumnName}`, ";
                    }
                }

                // Remove the trailing comma and space
                query = query.TrimEnd(',', ' ');

                // Add the table name and join statements
                query += $" FROM `{tableName}` g ";

                foreach (string oldColumnName in oldColumnNames)
                {
                    if (oldColumnName.StartsWith("id_"))
                    {
                        string referencedTableName = oldColumnName.Substring(3);  // Remove "id_" prefix
                        query += $"LEFT JOIN `{referencedTableName}` ON g.`{oldColumnName}` = `{referencedTableName}`.id ";
                    }
                }

                if (!string.IsNullOrEmpty(searchName))
                {
                    // Add the WHERE clause to filter by similar name
                    query += $"WHERE g.name LIKE '%{searchName}%' ";
                }

                if (numRows > 0)
                {
                    query += $"LIMIT {numRows}";
                }

                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Виникла помилка при отриманні даних з бази даних: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return dataTable;
        }

        // =======================================================================================

        /// <summary>
        /// Додавання запису в таблицю Goods
        /// </summary>
        /// <param name="id_warehouses"></param>
        /// <param name="id_prod_suppliers"></param>
        /// <param name="id_discounts"></param>
        /// <param name="id_tags"></param>
        /// <param name="id_prod_category"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        public void AddGoods(int idWarehouse, int idProdSupplier, int idDiscount, int idTag, int idProdCategory, string name, string description, decimal price)
        {
            try
            {
                openConnection();

                string query = "INSERT INTO goods (id_warehouses, id_prod_suppliers, id_discounts, id_tags, id_prod_category, name, description, price, created) " +
                               "VALUES (@idWarehouse, @idProdSupplier, @idDiscount, @idTag, @idProdCategory, @name, @description, @price, @created)";

                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@idWarehouse", idWarehouse);
                command.Parameters.AddWithValue("@idProdSupplier", idProdSupplier);
                command.Parameters.AddWithValue("@idDiscount", idDiscount);
                command.Parameters.AddWithValue("@idTag", idTag);
                command.Parameters.AddWithValue("@idProdCategory", idProdCategory);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении записи в таблицу 'goods': " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        // =======================================================================================

        /// <summary>
        /// Отримання назв таблиць з Бази данних
        /// </summary>
        /// <returns></returns>
        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            try
            {
                openConnection();

                string query = "SHOW TABLES";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tableName = reader.GetString(0);
                    tableNames.Add(tableName);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Виникла помилка при отриманні назв таблиць: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return tableNames;
        }


        /// <summary>
        /// Закритя підключення к базі даних
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
