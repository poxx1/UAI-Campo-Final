using System;
using System.Windows.Forms;
using Business;
using Models;
using Models.interfaces;
using Models.language;

namespace View
{
    public partial class frmReparaciones : Form, ILanguageObserber
    {
        public frmReparaciones()
        {
            InitializeComponent();
            cargarMaquinas();
            Session.GetInstance.addObserber(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calcula las horas y se la pasa a aprobaciones. La marco como revisada.
            Machines m = new Machines();
            MachinesService ms = new MachinesService();
            m = getCurrent();

            m.isPossibleToRepair = false;
            m.isReviewed = true;
            m.Reparation = "Imposible arreglar";

            ms.Review(m);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcula las horas y se la pasa a aprobaciones. La marco como revisada.
            Machines m = new Machines();
            MachinesService ms = new MachinesService();
            m = getCurrent();

            m.Reparation = richTextBox1.Text;

            m.isPossibleToRepair = true;
            m.isReviewed = true;

            ms.Review(m);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = getCurrent().Reparation.ToString();
        }
        private void cargarMaquinas()
        {
            MachinesService ms = new MachinesService();
            comboBox1.DataSource = null;
            comboBox1.DataSource = ms.GetAll();
            comboBox1.DisplayMember = "Id_Machine";
            richTextBox1.Text = getCurrent().Reparation.ToString(); 

            //comboBox1.Text = getCurrent().Id_Machine.ToString();
        }

        private Machines getCurrent()
        {
            Machines m = new Machines();
            m = (Machines)comboBox1.SelectedItem;
            if (m.isReviewed == true) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            return m;
        }

        #region Idioma
        public void updateLanguage(Language language)
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
        #endregion

        private void frmReparaciones_Load(object sender, EventArgs e)
        {   
            updateLanguage(Session.GetInstance.GetLanguage());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
