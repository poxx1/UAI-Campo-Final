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
using Models.interfaces;
using Models.language;

namespace View
{
    public partial class Approvals : Form, ILanguageObserber
    {
        public Approvals()
        {
            InitializeComponent();
            Session.GetInstance.addObserber(this);
            cargarMaquinas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calcula las horas y se la pasa a aprobaciones. La marco como revisada.
            Machines m = new Machines();
            MachinesService ms = new MachinesService();
            m = getCurrent();

            m.isApproved = false;

            ms.Approval(m);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcula las horas y se la pasa a aprobaciones. La marco como revisada.
            Machines m = new Machines();
            MachinesService ms = new MachinesService();
            m = getCurrent();

            m.isApproved = true;

            ms.Approval(m);
            ms.AssingToEmployee(m);
            //Aca llamo al metodo que asigna las maquinas.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cargarMaquinas()
        {
            MachinesService ms = new MachinesService();
            comboBox1.DataSource = null;
            comboBox1.DataSource = ms.GetAll();
            comboBox1.DisplayMember = "Id_Machine";

//            comboBox1.DisplayMember = getCurrent().Id_Machine.ToString();
        }

        private Machines getCurrent()
        {
            Machines m = new Machines();
            m = (Machines)comboBox1.SelectedItem;
            if (m.isReviewed == true) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            return m;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Machines m = new Machines();
            m = (Machines)comboBox1.SelectedItem;
            if (m.isReviewed == true) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            richTextBox1.Text = m.Reparation;
        }
        public void updateLanguage(Language language)
        {
            try
            {
                foreach (Control control in Controls)
                {
                    control.Text = language.Translations.Find(
                            (translation) => translation.Key.Equals(control.Tag)
                        )?.Translate ?? control.Text;
                    if (control.Controls.Count != 0)
                    {
                        updateLanguageRecursiveControls(language, control.Controls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateLanguageRecursiveControls(Language language, Control.ControlCollection parent)
        {
            foreach (Control control in parent)
            {
                control.Text = language.Translations.Find(
                        (translation) => translation.Key.Equals(control.Tag)
                    )?.Translate ?? control.Text;

                if (control.Controls.Count != 0)
                {
                    updateLanguageRecursiveControls(language, control.Controls);
                }
            }
        }

    }
}
