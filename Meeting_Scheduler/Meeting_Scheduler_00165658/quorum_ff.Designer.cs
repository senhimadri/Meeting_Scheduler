namespace Meeting_Scheduler_00165658
{
    partial class quorum_ff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textqur_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textMax_attendies = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textminattendis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.textqur_type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textMax_attendies);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textminattendis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 223);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Quorum";
            // 
            // textqur_type
            // 
            this.textqur_type.Location = new System.Drawing.Point(276, 72);
            this.textqur_type.Name = "textqur_type";
            this.textqur_type.Size = new System.Drawing.Size(202, 20);
            this.textqur_type.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(102, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Minimum attendies";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textMax_attendies
            // 
            this.textMax_attendies.Location = new System.Drawing.Point(277, 98);
            this.textMax_attendies.Name = "textMax_attendies";
            this.textMax_attendies.Size = new System.Drawing.Size(201, 20);
            this.textMax_attendies.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(102, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 60;
            this.label10.Text = "Max Attendence";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textminattendis
            // 
            this.textminattendis.Location = new System.Drawing.Point(277, 131);
            this.textminattendis.Name = "textminattendis";
            this.textminattendis.Size = new System.Drawing.Size(201, 20);
            this.textminattendis.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(102, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Quaram Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 259);
            this.dataGridView1.TabIndex = 57;
            // 
            // quorum_ff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "quorum_ff";
            this.Text = "Create Quorum";
            this.Load += new System.EventHandler(this.quorum_ff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textqur_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMax_attendies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textminattendis;
        private System.Windows.Forms.Label label11;
    }
}