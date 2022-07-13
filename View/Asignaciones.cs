using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using Models;
using Models.interfaces;
using Models.language;

namespace View
{
    public partial class Asignaciones : Form, ILanguageObserber
    {
        public Asignaciones()
        {
            InitializeComponent();

            //Machines m = new Machines();
            //UserService bldo
            UserService us = new UserService();
            //MachinesService ms = new MachinesService();

            List<User> listReparadores = new List<User>();
            List<User> temp = new List<User>();

            temp = us.GetAll();

            foreach (User user in temp)
            {
                if (user.isReparador)
                {
                    listReparadores.Add(user);
                }
            }

            comboBox1.DataSource = listReparadores;
            comboBox1.DisplayMember = "Id_User";
            Session.GetInstance.addObserber(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Asignaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
