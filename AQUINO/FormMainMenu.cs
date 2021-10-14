using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQUINO
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Construtor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //Métodos
        private Color SelectThemeColor() 
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender) 
        {
            if (btnSender != null) 
            {
                if (currentButton != (Button)btnSender) 
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
                    panelTitleBar.BackColor = color;
                    panelTopMenuLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton() 
        {
        foreach (Control previousBtn in panelMenu.Controls) 
            {
                if (previousBtn.GetType() == typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(34, 112, 147);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDeclaração_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCamisetas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
