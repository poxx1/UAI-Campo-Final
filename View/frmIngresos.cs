using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Models;

namespace View
{
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Machines machine = new Machines();

            machine.Brand = tb_Marca.Text;
            machine.Picture = "lafoto";
            machine.Failure = rtb_Failures.Text;
            machine.Id_Machine = '1';
            machine.Elements = rtb_Elements.Text;
            machine.Description = rtb_Description.Text;
            machine.Color = tb_Color.Text;
            machine.Model = tb_Modelo.Text;

            MachinesService ms = new MachinesService();
            ms.Save(machine);
        }
    }
}
