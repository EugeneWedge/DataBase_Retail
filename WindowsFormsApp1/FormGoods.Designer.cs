
namespace WindowsFormsApp1
{
    partial class FormGoods
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.panelDesktopMenu = new System.Windows.Forms.Panel();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFind = new System.Windows.Forms.Label();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudStr = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panelDesktopMenu.SuspendLayout();
            this.panel_Find.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelDataGridView);
            this.panelDesktop.Controls.Add(this.panelDesktopMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(755, 451);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewTable);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 150);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(755, 301);
            this.panelDataGridView.TabIndex = 1;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(755, 301);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // panelDesktopMenu
            // 
            this.panelDesktopMenu.Controls.Add(this.panel_Find);
            this.panelDesktopMenu.Controls.Add(this.panelMenu);
            this.panelDesktopMenu.Controls.Add(this.lblQuantity);
            this.panelDesktopMenu.Controls.Add(this.nudStr);
            this.panelDesktopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopMenu.Name = "panelDesktopMenu";
            this.panelDesktopMenu.Size = new System.Drawing.Size(755, 150);
            this.panelDesktopMenu.TabIndex = 0;
            // 
            // panel_Find
            // 
            this.panel_Find.Controls.Add(this.tableLayoutPanel1);
            this.panel_Find.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Find.Location = new System.Drawing.Point(250, 0);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(505, 70);
            this.panel_Find.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblFind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Find, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Find, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFind.ForeColor = System.Drawing.Color.White;
            this.lblFind.Location = new System.Drawing.Point(82, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Padding = new System.Windows.Forms.Padding(5);
            this.lblFind.Size = new System.Drawing.Size(66, 27);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Пошук";
            // 
            // textBox_Find
            // 
            this.textBox_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Find.Location = new System.Drawing.Point(154, 3);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(348, 22);
            this.textBox_Find.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(154, 31);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(348, 36);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Пошук";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnInsert);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 150);
            this.panelMenu.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(553, 124);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Кількість строк";
            // 
            // nudStr
            // 
            this.nudStr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudStr.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudStr.Location = new System.Drawing.Point(688, 122);
            this.nudStr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStr.Name = "nudStr";
            this.nudStr.ReadOnly = true;
            this.nudStr.Size = new System.Drawing.Size(64, 22);
            this.nudStr.TabIndex = 0;
            this.nudStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStr.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudStr.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 98);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "   Змінити";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(250, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "   Видалити";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Image = global::WindowsFormsApp1.Properties.Resources.insert;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(250, 49);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "   Вставити";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 451);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormGoods";
            this.Text = "FormGoods";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGoods_KeyDown);
            this.panelDesktop.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panelDesktopMenu.ResumeLayout(false);
            this.panelDesktopMenu.PerformLayout();
            this.panel_Find.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Panel panelDesktopMenu;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudStr;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button button1;
    }
}