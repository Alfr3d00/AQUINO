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
        private Form activeForm;

        //Construtor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
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
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
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

        //Método que abre os formulários no container
        private void OpenChildForm(Form childForm, object btnSender) 
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //Exibe devido título
            lblTitulo.Text = childForm.Text;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormBuscar(), sender);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormCadastrar(), sender);
        }

        private void btnDeclaração_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormDeclaracao(), sender);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormFinanceiro(), sender);
        }

        private void btnCamisetas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormCamisetas(), sender);
        }

        private void btnRenovacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.FormRenovacao(), sender);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)     
                activeForm.Close();
            Reset();
            
        }

        private void Reset()
        {
            DisableButton();
            lblTitulo.Text = "Menu Principal";
            panelTitleBar.BackColor = Color.FromArgb(15, 185, 177);
            panelTopMenuLogo.BackColor = Color.FromArgb(14, 92, 127);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
