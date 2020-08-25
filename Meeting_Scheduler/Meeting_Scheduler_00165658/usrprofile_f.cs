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
    public partial class usrprofile_f : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public usrprofile_f()
        {
            InitializeComponent();
        }

        private void reload()
        {
            int a = gloval.my_user_id;

            var data = DB.Users.Where(x => x.u_Id == a).FirstOrDefault();


            if (data != null)
            {




                textName.Text = data.uName;
                textpass.Text = data.Pass;
                cmbJob.Text = data.Job_Title;

                textAge.Text = data.Age;
                cmbGender.Text = data.Gender;
                cmbGrade.Text = data.Pay_Grade;


            }
        }

        private void usrprofile_f_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = gloval.my_user_id;
            var data = DB.Users.Where(x => x.u_Id == a).FirstOrDefault();
            

            if (data != null)
            {

                
                data.uName = textName.Text;
                data.Pass = textpass.Text;


                data.Job_Title = cmbJob.Text;
                data.Age = textAge.Text;
                data.Gender = cmbGender.Text;
                data.Pay_Grade = cmbGrade.Text;


                DB.SaveChanges();

                MessageBox.Show("Your Profile is updated");
                reload();

                
            }
        }
    }
}
