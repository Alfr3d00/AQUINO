using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQUINO.Formularios
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
            
        }

        private void FormBuscar_Load(object sender, EventArgs e) 
        {
            LoadTheme();
        }

        private void LoadTheme() 
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;    
                }
            }
        }
    }
}
