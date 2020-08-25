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
    public partial class meeting_ff : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public meeting_ff()
        {
            InitializeComponent();
        }

        private void meeting_ff_Load(object sender, EventArgs e)
        {
            comboitems();
        }

        private void comboitems()
        {
            comboag_type.DataSource = DB.Agenda.ToList();
            comboag_type.DisplayMember = "Title";
            comboag_type.ValueMember = "ag_Id";

            combovenu.DataSource = DB.Venus.ToList();
            combovenu.DisplayMember = "vName";
            combovenu.ValueMember = "v_Id";

            combquaram.DataSource = DB.Quarams.ToList();
            combquaram.DisplayMember = "qType";
            combquaram.ValueMember = "q_Id";

            

            var data11 = DB.Meetings.ToList();



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data11;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            var data = DB.Calenders.Where(x => x.cDate == dateTimePicker1.Value.Date).FirstOrDefault();



            int cal_id = data.c_Id;

            int a = Int32.Parse(comboag_type.SelectedValue.ToString());
            int vv = Int32.Parse(combovenu.SelectedValue.ToString());
            int qq = Int32.Parse(combquaram.SelectedValue.ToString());


            Meeting m = new Meeting()

            {
                mTitle = texttitle.Text,
                cId = cal_id,
                qId = qq,
                vId = vv,
                aId = a,
                Start_Time = comboBox1.SelectedIndex ,
                
                Duration = Int32.Parse(textduration.Text)


            };

            DB.Meetings.Add(m);
            DB.SaveChanges();


       


            MessageBox.Show("Meating Is Created");

            comboitems();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);


            var data = DB.Meetings.Where(x => x.m_Id == a).FirstOrDefault();
            //var data = db.Agenda.Where(x => x.Title.Contains(txtTitle.Text)).FirstOrDefault();

            var data1 = DB.Calenders.Where(y => y.c_Id == data.cId).FirstOrDefault();



            if (data != null)
            {

               
                //txtID.Text = data.Id.ToString();
                //txtTitle.Text = data.Title;
                //txtDes.Text = data.Description;
                //cmbType.Text = data.Type;

                texttitle.Text = data.mTitle;
                combquaram.SelectedValue = data.qId;
                combovenu.SelectedValue = data.vId;
                comboag_type.SelectedValue = data.aId;
                dateTimePicker1.Value = data1.cDate.Value;
                comboBox1.SelectedValue = data.Start_Time;
                textduration.Text = data.Duration.ToString();


            }
            else
            {
                MessageBox.Show("Data Paoyta jai nai !!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int aa = Int32.Parse(textBox1.Text);
            var data = DB.Meetings.Where(x => x.m_Id == aa).FirstOrDefault();
          

            int a = Int32.Parse(comboag_type.SelectedValue.ToString());
            int vv = Int32.Parse(combovenu.SelectedValue.ToString());
            int qq = Int32.Parse(combquaram.SelectedValue.ToString());
            if (data != null)
            {
                data.mTitle = texttitle.Text;

                data.Start_Time = comboBox1.SelectedIndex;
                data.aId = a;
                data.vId = vv;
                data.qId = qq;
                data.Duration = Int32.Parse(textduration.Text);

                DB.SaveChanges();
                MessageBox.Show("Data Updated");

                comboitems();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            var data = DB.Meetings.Where(x => x.m_Id == a).FirstOrDefault();
            //var data = db.Agenda.Where(x => x.Title.Contains(txtTitle.Text)).FirstOrDefault();

            if (data != null)
            {

                DB.Meetings.Remove(data);
                DB.SaveChanges();
                comboitems();
 
            }
            else
            {
                MessageBox.Show("Data Is Not Found!!!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            comboitems();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
