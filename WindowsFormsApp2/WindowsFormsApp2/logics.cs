using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class logics
    {


        public static int rolldice(PictureBox px)
        {

            int dice = 0;
            Random rnd = new Random();
            dice = rnd.Next(1, 7);
            //C:\Users\ARIEL.DESKTOP-K09BLLE\Documents\Elad's projects\Snake Ladder Game\WindowsFormsApp2\WindowsFormsApp2\Resources\3.jpg
            px.Image = Image.FromFile(@"C:\Users\Elad Berger\Documents\programing projects\C#\Snake Ladder Game\WindowsFormsApp2\WindowsFormsApp2\Resources\" + dice + ".jpg");
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;



        }


        public static int move(ref int x, ref int y, ref int p, int dice, PictureBox px, Label l,Label l1,Label l2 )
        {
            if (dice+p>100)
            {
                l.Text = "can not move";
                l.ForeColor = System.Drawing.Color.Red;
                


            }
            else {
                for (int i = 0; i < dice; i++)
                {


                    if (p % 10 == 0 && p > 0)
                    {
                        x = 3;
                        y = y - 53;
                    }
                    else
                    {
                        x += 75;

                    }
                    l.Text = p.ToString();
                    px.Location = new Point(x, y);
                    p++;
                    
                }
            }
            if (p==3)
            {
                x = 3;
                y = 233;
                p = 51;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==6)
            {
                x = 445;
                y = 390;
                p = 27;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==20)
            {
                x = 673;
                y = 178;
                p = 70;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==36)
            {
                x = 300;
                y = 232;
                p = 55;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==63)
            {
                x = 302;
                y = 19;
                p = 95;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==68)
            {
                x = 526;
                y = 19;
                p = 98;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }

            if (p==25)
            {
                x = 302;
                y = 496;
                p = 5;
                l.Text = p.ToString();
                px.Location = new Point(x, y);

            }
            if (p==34)
            {
                x = 3;
                y = 499;
                p = 1;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }

            if (p==47)
            {
                x = 598;
                y = 443;
                p = 19;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==65)
            {
                x = 77;
                y = 231;
                p = 52;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==87)
            {
                x = 451;
                y = 233;
                p = 57;
                l.Text = p.ToString();
                px.Location = new Point(x, y);

            }
            if (p==91)
            {
                x = 4;
                y = 179;
                p = 61;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }
            if (p==99)
            {
                x = 600;
                y = 178;
                p = 69;
                l.Text = p.ToString();
                px.Location = new Point(x, y);
            }

            l1.Text = x.ToString();
            l2.Text = y.ToString();


            return p;

        }

    }
}
