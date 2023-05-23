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
    public partial class Form_DataBase : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm; // переменная для отслеживания активной формы
        // Constructor
        public Form_DataBase()
        {
            InitializeComponent();
            random = new Random();
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelLogo.BackColor = Color.FromArgb(34, 32, 77);
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 58);
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
        }

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
              index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    panelShadow.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void DisableButton() 
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 30, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Товари";
            OpenChildForm(new FormGoods());
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Замовлення";
            OpenChildForm(new FormOrders());
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Запаси товарів";
            OpenChildForm(new FormStocks());
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Повідомлення";
            OpenChildForm(new FormNotifications());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Настройки";
            OpenChildForm(new FormSettings());
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // закрыть предыдущую активную форму

            activeForm = childForm; // установить новую активную форму
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelTitleBar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
        }

    }
}
