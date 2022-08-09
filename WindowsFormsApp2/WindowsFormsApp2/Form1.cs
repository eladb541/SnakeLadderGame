using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int flag;
        int startx = 3;
        int starty = 496;
        int x = 3;
        int y = 496;
        int xx = 3;
        int yy = 496;
        int dicevalue;
        int p = 1;//pos of orange
        int q = 1;//pos of light blue

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = 1;
            if (flag%2!=0)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;

            }
            
            
            pictureBox3.Image = Image.FromFile(@"C:\Users\Elad Berger\Documents\programing projects\C#\Snake Ladder Game\WindowsFormsApp2\WindowsFormsApp2\Resources\rolling.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            label5.Text = startx.ToString();
            label6.Text = starty.ToString();
            label11.Text= startx.ToString();
            label13.Text= starty.ToString();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            panel2.BackColor = Color.Orange;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                dicevalue = logics.rolldice(pictureBox3);
                label2.Text= dicevalue.ToString();
                
                p= logics.move(ref x, ref y, ref p, dicevalue, pictureBox4, label8,label5,label6);
                label8.Text = p.ToString();
            if (p == 100)
            {
                MessageBox.Show("winner");
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else {
                button1.Enabled = false;
                button2.Enabled = true;
                panel2.BackColor = Color.MediumTurquoise;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
                dicevalue = logics.rolldice(pictureBox3);
                label2.Text = dicevalue.ToString();
                
                q = logics.move(ref xx, ref yy, ref q, dicevalue, pictureBox5, label9, label11, label13);
                label9.Text = q.ToString();
                if (q == 100)
                {
                    MessageBox.Show("winner");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            else
            { 
            button1.Enabled = true;
            button2.Enabled = false;
                panel2.BackColor = Color.Orange;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }
    }
}
