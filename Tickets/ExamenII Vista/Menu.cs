using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII_Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NTicketToolStripButton_Click(object sender, EventArgs e)
        {
            NuevoTicketForm nuevoTicketForm = new NuevoTicketForm();
            nuevoTicketForm.MdiParent = this;
            nuevoTicketForm.Show();

        }
    }
}
