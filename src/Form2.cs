using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4buyukleroyun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random skor = new Random();
        bool skorAtandi = false; // Skorun atanıp atanmadığını kontrol eden bayrak
        bool skorAtandi2 = false;
        bool skorAtandi3 = false;
        bool skorAtandi4 = false;
        bool skorAtandi5 = false;
        bool skorAtandi6 = false;
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!skorAtandi)
            {
                int haftabirgs = skor.Next(0, 3);
                label4.Text = haftabirgs.ToString();
                int haftabirfb = skor.Next(0, 3);
                label5.Text = haftabirfb.ToString();
                int haftabirbjk = skor.Next(0, 3);
                label8.Text = haftabirbjk.ToString();
                int haftabirts = skor.Next(0, 3);
                label6.Text = haftabirts.ToString();
                skorAtandi = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }
            // button1.Enabled=False; de yapabilirsin.
            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else if ((Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text)))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else
            {
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
                gspuan += 1;
                label65.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else if ((Convert.ToInt32(label6.Text) < Convert.ToInt32(label8.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                tspuan += 1;
                label68.Text = tspuan.ToString();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (!skorAtandi2)
            {
                int haftaikigs = skor.Next(0, 3);
                label13.Text = haftaikigs.ToString();
                int haftaikifb = skor.Next(0, 3);
                label17.Text = haftaikifb.ToString();
                int haftaikibjk = skor.Next(0, 3);
                label11.Text = haftaikibjk.ToString();
                int haftaikits = skor.Next(0, 3);
                label14.Text = haftaikits.ToString();
                skorAtandi2 = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label17.Text))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else if ((Convert.ToInt32(label13.Text) < Convert.ToInt32(label17.Text)))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else
            {
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
                gspuan += 1;
                label65.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label11.Text))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else if ((Convert.ToInt32(label14.Text) < Convert.ToInt32(label11.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                tspuan += 1;
                label68.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!skorAtandi3)
            {
                int haftaucgs = skor.Next(0, 3);
                label23.Text = haftaucgs.ToString();
                int haftaucfb = skor.Next(0, 3);
                label24.Text = haftaucfb.ToString();
                int haftaucbjk = skor.Next(0, 3);
                label27.Text = haftaucbjk.ToString();
                int haftaucts = skor.Next(0, 3);
                label21.Text = haftaucts.ToString();
                skorAtandi3 = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }


            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label27.Text))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else if ((Convert.ToInt32(label23.Text) < Convert.ToInt32(label27.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                gspuan += 1;
                label65.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label24.Text) > Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else if ((Convert.ToInt32(label24.Text) < Convert.ToInt32(label21.Text)))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else
            {
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
                tspuan += 1;
                label68.Text = tspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!skorAtandi4)
            {
                int haftadortgs = skor.Next(0, 3);
                label37.Text = haftadortgs.ToString();
                int haftadortfb = skor.Next(0, 3);
                label31.Text = haftadortfb.ToString();
                int haftadortbjk = skor.Next(0, 3);
                label33.Text = haftadortbjk.ToString();
                int haftadortts = skor.Next(0, 3);
                label34.Text = haftadortts.ToString();
                skorAtandi4 = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }
            if (Convert.ToInt32(label33.Text) > Convert.ToInt32(label37.Text))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else if ((Convert.ToInt32(label33.Text) < Convert.ToInt32(label37.Text)))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                gspuan += 1;
                label65.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label34.Text))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else if ((Convert.ToInt32(label31.Text) < Convert.ToInt32(label34.Text)))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else
            {
                tspuan += 1;
                label67.Text = tspuan.ToString();
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (!skorAtandi5)
            {
                int haftadortgs = skor.Next(0, 3);
                label47.Text = haftadortgs.ToString();
                int haftadortfb = skor.Next(0, 3);
                label41.Text = haftadortfb.ToString();
                int haftadortbjk = skor.Next(0, 3);
                label44.Text = haftadortbjk.ToString();
                int haftadortts = skor.Next(0, 3);
                label43.Text = haftadortts.ToString();
                skorAtandi5 = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }
            if (Convert.ToInt32(label43.Text) > Convert.ToInt32(label47.Text))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else if ((Convert.ToInt32(label43.Text) < Convert.ToInt32(label47.Text)))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else
            {
                gspuan += 1;
                label65.Text = gspuan.ToString();
                tspuan += 1;
                label68.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label44.Text) > Convert.ToInt32(label41.Text))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else if ((Convert.ToInt32(label44.Text) < Convert.ToInt32(label41.Text)))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            if (!skorAtandi6)
            {
                int haftadortgs = skor.Next(0, 3);
                label53.Text = haftadortgs.ToString();
                int haftadortfb = skor.Next(0, 3);
                label54.Text = haftadortfb.ToString();
                int haftadortbjk = skor.Next(0, 3);
                label51.Text = haftadortbjk.ToString();
                int haftadortts = skor.Next(0, 3);
                label57.Text = haftadortts.ToString();
                skorAtandi6 = true; // Skor atandı, tekrar değiştirilmesini önle
            }
            else
            {
                MessageBox.Show("Zaten bir skor atanmış!");
            }
            if (Convert.ToInt32(label57.Text) > Convert.ToInt32(label53.Text))
            {
                tspuan = tspuan + 3;
                label68.Text = tspuan.ToString();
            }
            else if ((Convert.ToInt32(label57.Text) < Convert.ToInt32(label53.Text)))
            {
                gspuan = gspuan + 3;
                label65.Text = gspuan.ToString();
            }
            else
            {
                tspuan += 1;
                label68.Text = tspuan.ToString();
                gspuan += 1;
                label65.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label54.Text) > Convert.ToInt32(label51.Text))
            {
                fbpuan = fbpuan + 3;
                label66.Text = fbpuan.ToString();
            }
            else if ((Convert.ToInt32(label54.Text) < Convert.ToInt32(label51.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label67.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan += 1;
                label67.Text = bjkpuan.ToString();
                fbpuan += 1;
                label66.Text = fbpuan.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(label65.Text) > Convert.ToInt32(label66.Text)&& (Convert.ToInt32(label65.Text) > Convert.ToInt32(label67.Text))&& (Convert.ToInt32(label65.Text) > Convert.ToInt32(label68.Text))))
            {
                MessageBox.Show("Şampiyon Cimbommmmmmmmmmm!");
            }
            if ((Convert.ToInt32(label66.Text) > Convert.ToInt32(label65.Text) && (Convert.ToInt32(label66.Text) > Convert.ToInt32(label67.Text)) && (Convert.ToInt32(label66.Text) > Convert.ToInt32(label68.Text))))
            {
                MessageBox.Show("Şampiyon Fenerrrr!");
            }
            if ((Convert.ToInt32(label67.Text) > Convert.ToInt32(label66.Text) && (Convert.ToInt32(label67.Text) > Convert.ToInt32(label66.Text)) && (Convert.ToInt32(label67.Text) > Convert.ToInt32(label68.Text))))
            {
                MessageBox.Show("Şampiyon Karakartal!");
            }
            if ((Convert.ToInt32(label68.Text) > Convert.ToInt32(label65.Text) && (Convert.ToInt32(label68.Text) > Convert.ToInt32(label66.Text)) && (Convert.ToInt32(label68.Text) > Convert.ToInt32(label67.Text))))
            {
                MessageBox.Show("Çupamuzu verin!");
            }





        }
    }
}



