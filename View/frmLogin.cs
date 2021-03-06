using System;
using System.Threading;
using System.Windows.Forms;
using Business;
using Utiles;

namespace View
{
    public partial class frmLogin : Form
    {
        SessionService sessionService;

        public frmLogin()
        {
            InitializeComponent();
            sessionService = new SessionService();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sessionService.Login(textBox1.Text, textBox2.Text);
                this.Hide();
                new frmMain(this).Show();      
            }
            catch (Exception ex)
            {
                button1.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);

            }
            finally
            {
                clearForm();
            }
        }


        private  void clearForm()
        {
            //textBox1.Clear();
            //textBox2.Clear();
            textBox1.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
