
namespace WindowsFormsApp1
{
    partial class FormUpdateGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_prod_category = new System.Windows.Forms.ComboBox();
            this.comboBox_tags = new System.Windows.Forms.ComboBox();
            this.comboBox_discounts = new System.Windows.Forms.ComboBox();
            this.comboBox_prod_suppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.comboBox_warehouses = new System.Windows.Forms.ComboBox();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_NameGoods = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_prod_category
            // 
            this.comboBox_prod_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_prod_category.FormattingEnabled = true;
            this.comboBox_prod_category.Location = new System.Drawing.Point(243, 349);
            this.comboBox_prod_category.Name = "comboBox_prod_category";
            this.comboBox_prod_category.Size = new System.Drawing.Size(554, 24);
            this.comboBox_prod_category.TabIndex = 6;
            // 
            // comboBox_tags
            // 
            this.comboBox_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tags.FormattingEnabled = true;
            this.comboBox_tags.Location = new System.Drawing.Point(243, 319);
            this.comboBox_tags.Name = "comboBox_tags";
            this.comboBox_tags.Size = new System.Drawing.Size(554, 24);
            this.comboBox_tags.TabIndex = 5;
            // 
            // comboBox_discounts
            // 
            this.comboBox_discounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_discounts.FormattingEnabled = true;
            this.comboBox_discounts.Location = new System.Drawing.Point(243, 289);
            this.comboBox_discounts.Name = "comboBox_discounts";
            this.comboBox_discounts.Size = new System.Drawing.Size(554, 24);
            this.comboBox_discounts.TabIndex = 4;
            // 
            // comboBox_prod_suppliers
            // 
            this.comboBox_prod_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_prod_suppliers.FormattingEnabled = true;
            this.comboBox_prod_suppliers.Location = new System.Drawing.Point(243, 258);
            this.comboBox_prod_suppliers.Name = "comboBox_prod_suppliers";
            this.comboBox_prod_suppliers.Size = new System.Drawing.Size(554, 24);
            this.comboBox_prod_suppliers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 60);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва товару";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 88);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Опис товару";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 224);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Склад зберігання";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 255);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(180, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Постачальник товару";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(164, 286);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Знижка";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 316);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Мітка";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 346);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(147, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Категорія товару";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(185, 376);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ціна";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Location = new System.Drawing.Point(243, 91);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(554, 130);
            this.textBox_Description.TabIndex = 1;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Price.Location = new System.Drawing.Point(243, 379);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(554, 22);
            this.textBox_Price.TabIndex = 1;
            // 
            // comboBox_warehouses
            // 
            this.comboBox_warehouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_warehouses.FormattingEnabled = true;
            this.comboBox_warehouses.Location = new System.Drawing.Point(243, 227);
            this.comboBox_warehouses.Name = "comboBox_warehouses";
            this.comboBox_warehouses.Size = new System.Drawing.Size(554, 24);
            this.comboBox_warehouses.TabIndex = 2;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(800, 450);
            this.panelDeskTop.TabIndex = 1;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_category, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_prod_category, 1, 8);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_tags, 1, 7);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_discounts, 1, 6);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_prod_suppliers, 1, 5);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanelDeskTop.Controls.Add(this.textBox_Name, 1, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.textBox_Description, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.textBox_Price, 1, 9);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_warehouses, 1, 4);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnUpdate, 1, 10);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.comboBox_NameGoods, 1, 0);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 12;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelDeskTop.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(243, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(554, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Змінити товар";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(243, 63);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(554, 22);
            this.textBox_Name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(174, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(63, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Товар";
            // 
            // comboBox_NameGoods
            // 
            this.comboBox_NameGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_NameGoods.FormattingEnabled = true;
            this.comboBox_NameGoods.Location = new System.Drawing.Point(243, 3);
            this.comboBox_NameGoods.Name = "comboBox_NameGoods";
            this.comboBox_NameGoods.Size = new System.Drawing.Size(554, 24);
            this.comboBox_NameGoods.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(146, 30);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(91, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "Категорія";
            // 
            // comboBox_category
            // 
            this.comboBox_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(243, 33);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(554, 24);
            this.comboBox_category.TabIndex = 11;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // FormUpdateGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDeskTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormUpdateGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зміна товару";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_prod_category;
        private System.Windows.Forms.ComboBox comboBox_tags;
        private System.Windows.Forms.ComboBox comboBox_discounts;
        private System.Windows.Forms.ComboBox comboBox_prod_suppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ComboBox comboBox_warehouses;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_NameGoods;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label10;
    }
}