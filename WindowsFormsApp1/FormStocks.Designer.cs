
namespace WindowsFormsApp1
{
    partial class FormStocks
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.panelDesktopMenu = new System.Windows.Forms.Panel();
            this.nudStr = new System.Windows.Forms.NumericUpDown();
            this.panelDesktop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panelDesktopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(598, 124);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Кількість строк";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelDataGridView);
            this.panelDesktop.Controls.Add(this.panelDesktopMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 450);
            this.panelDesktop.TabIndex = 8;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewTable);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 150);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(800, 300);
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
            this.dataGridViewTable.Size = new System.Drawing.Size(800, 300);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // panelDesktopMenu
            // 
            this.panelDesktopMenu.Controls.Add(this.lblQuantity);
            this.panelDesktopMenu.Controls.Add(this.nudStr);
            this.panelDesktopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopMenu.Name = "panelDesktopMenu";
            this.panelDesktopMenu.Size = new System.Drawing.Size(800, 150);
            this.panelDesktopMenu.TabIndex = 0;
            // 
            // nudStr
            // 
            this.nudStr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudStr.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudStr.Location = new System.Drawing.Point(733, 122);
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
            this.nudStr.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged_1);
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormStocks";
            this.Text = "FormStocks";
            this.panelDesktop.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panelDesktopMenu.ResumeLayout(false);
            this.panelDesktopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Panel panelDesktopMenu;
        private System.Windows.Forms.NumericUpDown nudStr;
    }
}