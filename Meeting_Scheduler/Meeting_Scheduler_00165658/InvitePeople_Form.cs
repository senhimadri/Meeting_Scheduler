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
    public partial class InvitePeople_Form : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public InvitePeople_Form()
        {
            InitializeComponent();
        }
    

        private void InvitePeople_Form_Load(object sender, EventArgs e)
        {
            comboitems();
        }

        private void comboitems()
        {
            comboBox1.DataSource = DB.Meetings.ToList();
            comboBox1.DisplayMember = "mTitle";
            comboBox1.ValueMember = "m_Id";

            comboBox3.DataSource = DB.Users.ToList();
            comboBox3.DisplayMember = "uName";
            comboBox3.ValueMember = "u_Id";




            var data11 = DB.MeetAttendies.ToList();



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data11;

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

           

            int a = Int32.Parse(comboBox1.SelectedValue.ToString());
            int usr_id = Int32.Parse(comboBox3.SelectedValue.ToString());

            MeetAttendy mqq = new MeetAttendy()

            {
            u_id= usr_id,
            m_id = a,
            Remarks= textBox1.Text,
            R_Time=comboBox1.Text,
            Present= 1



            };

            DB.MeetAttendies.Add(mqq);
            DB.SaveChanges();





            MessageBox.Show("Invitation Is Send");

            comboitems();
        }
    }
}
