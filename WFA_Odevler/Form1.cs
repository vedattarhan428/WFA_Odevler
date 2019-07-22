using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WFA_Odevler
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {

            //t1.Text = "0";
            //t2.Text = "0";
            //t3.Text = "0";
            //t4.Text = "0";
            //t5.Text = "0";
            //t6.Text = "0";


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "0";
                }
            }

            _index = 0;

            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        int[] sayilar = new int[6];
        int _index = 0;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 50);

            if (_index < 10)
            {
                if (_index == 9)
                {
                    sayilar[0] = sayi;
                }
                t1.Text = sayi.ToString();
            }
            else if (_index < 20)
            {
                if (_index == 19)
                {
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar[1] = sayi;
                    }
                    else
                    {
                        _index--;
                    }
                }
                t2.Text = sayi.ToString();
            }
            else if (_index < 30)
            {
                if (_index == 29)
                {
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar[2] = sayi;
                    }
                    else
                    {
                        _index--;
                    }
                }
                t3.Text = sayi.ToString();
            }
            else if (_index < 40)
            {
                if (_index == 39)
                {
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar[3] = sayi;
                    }
                    else
                    {
                        _index--;
                    }
                }
                t4.Text = sayi.ToString();
            }
            else if (_index < 50)
            {
                if (_index == 49)
                {
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar[4] = sayi;
                    }
                    else
                    {
                        _index--;
                    }
                }
                t5.Text = sayi.ToString();
            }
            else if (_index < 60)
            {
                if (_index == 59)
                {
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar[5] = sayi;
                    }
                    else
                    {
                        _index--;
                    }
                }
                t6.Text = sayi.ToString();
            }

            if (_index == 70)
            {
                timer1.Stop();
                Array.Sort(sayilar);

                //t1.Text = sayilar[0].ToString();
                //t2.Text = sayilar[1].ToString();
                //t3.Text = sayilar[2].ToString();
                //t4.Text = sayilar[3].ToString();
                //t5.Text = sayilar[4].ToString();
                //t6.Text = sayilar[5].ToString();


                for (int i = 0; i < sayilar.Length; i++)
                {
                    //Control[] cl = this.Controls.Find("t" + (i + 1), false);
                    //Control c = cl[0];
                    //c.Text = sayilar[i].ToString();

                    (this.Controls.Find("t" + (i + 1), false)[0]).Text = sayilar[i].ToString();
                }

                //foreach (Control ctrl in Controls)
                //{
                //    if (ctrl is TextBox)
                //    {
                //        ctrl.Text = sayilar[Convert.ToInt32(ctrl.Tag)].ToString();
                //    }
                //}


                //int index = 0;
                //while (index < Controls.Count)
                //{
                //    if (Controls[index] is TextBox)
                //    {
                //        Controls[index].Text = sayilar[Controls[index].TabIndex].ToString();
                //    }
                //}
            }
            _index++;
        }
    }
}


