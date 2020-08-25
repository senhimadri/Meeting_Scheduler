using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduler_00165658
{
    public partial class register_f : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public register_f()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User x = new User()

            {
                uName = textName.Text,

                Job_Title = cmbJob.Text,
                Pay_Grade = cmbGrade.Text,
                Gender = cmbGender.Text,
                Pass = textpass.Text,
                Role_Id = 1,
                Age = textAge.Text

            };

            DB.Users.Add(x);
            DB.SaveChanges();


            MessageBox.Show("Register Successfully");

            Login_f f2 = new Login_f();
            this.Visible = false;
            f2.Visible = true;
        }

        private void register_f_Load(object sender, EventArgs e)
        {

        }
    }
}
