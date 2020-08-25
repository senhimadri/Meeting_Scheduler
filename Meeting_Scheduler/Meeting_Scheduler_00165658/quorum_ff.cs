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
    public partial class quorum_ff : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public quorum_ff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quaram qq = new Quaram()

            {
                qType = textqur_type.Text,
                max_Att = Int32.Parse(textMax_attendies.Text),

                min_Att = Int32.Parse(textminattendis.Text)



            };

            DB.Quarams.Add(qq);
            DB.SaveChanges();
            MessageBox.Show("Quaram Is Added");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Quarams.ToList();


        }

        private void quorum_ff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Quarams.ToList();
        }
    }
}
