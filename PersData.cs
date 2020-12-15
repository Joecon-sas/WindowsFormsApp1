using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pers_Data : Form
    {
        public Pers_Data()
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pers_Data_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Effdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resident Record Type:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Employee",
            "Registered Voter",
            "Temporary Resident"});
            this.checkedListBox1.Location = new System.Drawing.Point(927, 148);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(462, 109);
            this.checkedListBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1450, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Effective Date:";
            // 
            // Effdt
            // 
            this.Effdt.Location = new System.Drawing.Point(4310, 263);
            this.Effdt.Name = "Effdt";
            this.Effdt.Size = new System.Drawing.Size(404, 38);
            this.Effdt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resident  ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(872, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 38);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(50, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 80);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resident Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(23, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 358);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(591, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Birth";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(872, 338);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 38);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(45, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2083, 310);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 707);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "First Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 704);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(751, 38);
            this.textBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 797);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Middle Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 887);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(308, 805);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(751, 38);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(308, 887);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(753, 38);
            this.textBox5.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 1011);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Marital Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(887, 1011);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gender:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Separated"});
            this.checkedListBox2.Location = new System.Drawing.Point(345, 1011);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(374, 179);
            this.checkedListBox2.TabIndex = 22;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to disclose"});
            this.checkedListBox3.Location = new System.Drawing.Point(1105, 1011);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(358, 109);
            this.checkedListBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(591, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "Voter ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(872, 514);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(474, 38);
            this.textBox6.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.telephonesToolStripMenuItem,
            this.dependentsToolStripMenuItem,
            this.employmentToolStripMenuItem,
            this.videoCallToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2433, 49);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(149, 50);
            this.addressToolStripMenuItem.Text = "Address";
            // 
            // telephonesToolStripMenuItem
            // 
            this.telephonesToolStripMenuItem.Name = "telephonesToolStripMenuItem";
            this.telephonesToolStripMenuItem.Size = new System.Drawing.Size(193, 50);
            this.telephonesToolStripMenuItem.Text = "Telephones";
            // 
            // dependentsToolStripMenuItem
            // 
            this.dependentsToolStripMenuItem.Name = "dependentsToolStripMenuItem";
            this.dependentsToolStripMenuItem.Size = new System.Drawing.Size(204, 50);
            this.dependentsToolStripMenuItem.Text = "Dependents";
            // 
            // employmentToolStripMenuItem
            // 
            this.employmentToolStripMenuItem.Name = "employmentToolStripMenuItem";
            this.employmentToolStripMenuItem.Size = new System.Drawing.Size(210, 50);
            this.employmentToolStripMenuItem.Text = "Employment";
            // 
            // videoCallToolStripMenuItem
            // 
            this.videoCallToolStripMenuItem.Name = "videoCallToolStripMenuItem";
            this.videoCallToolStripMenuItem.Size = new System.Drawing.Size(176, 50);
            this.videoCallToolStripMenuItem.Text = "Video Call";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(144, 50);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1690, 161);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(387, 38);
            this.textBox7.TabIndex = 32;
            // 
            // Pers_Data
            // 
            this.ClientSize = new System.Drawing.Size(2433, 1276);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Effdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pers_Data";
            this.Text = "Resident Data";
            this.Load += new System.EventHandler(this.Pers_Data_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Pers_Data_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
