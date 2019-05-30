using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack___SIO
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }


        private void btn_1plyr_Click(object sender, EventArgs e)
        {
            Form_tablero_1pl form_Tablero_1Pl = new Form_tablero_1pl();
            form_Tablero_1Pl.ShowDialog();
        }

        private void btn_2plyr_Click(object sender, EventArgs e)
        {
            Form_tablero_2pl form_Tablero_2Pl = new Form_tablero_2pl();
            form_Tablero_2Pl.ShowDialog();
            


        }
    }
}
