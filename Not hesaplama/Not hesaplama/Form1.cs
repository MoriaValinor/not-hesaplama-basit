namespace Not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "��RENC� NOT HESAPLAMA  |  " + DateTime.Now;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 47 || e.KeyChar > 59) // sadece karakter yazmak 
            {
                e.Handled = false;// karakter d���ndakileri yazma
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 47 || e.KeyChar > 59) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 59) && (e.KeyChar != 8)) // 48 - 59 asci tablosu
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 59) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 59) && (e.KeyChar != 8)) 
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }



        double vize, final, odev, ortalama;
        string harf, durum;
        DialogResult cvp;

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("��RENC�N�N ADINI YAZINIZ !");
                textBox1.Focus();
                textBox1.BackColor = Color.Aqua;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("��RENC�N�N SOYADINI YAZINIZ !");
                textBox2.Focus();
                textBox2.BackColor = Color.Aqua;
            }
            else if (textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "")
            {
                MessageBox.Show("��RENC�N�N SINAV NOTUNU G�R�N�Z", "HATA");
                textBox3.Focus();
                textBox3.BackColor = Color.Yellow;
                textBox4.BackColor = Color.Yellow;
                textBox5.BackColor = Color.Yellow;
            }
            else
            {
                vize = Convert.ToDouble(textBox3.Text);
                final = Convert.ToDouble(textBox4.Text);
                odev = Convert.ToDouble(textBox5.Text);

                ortalama = (vize + final + odev) / 3;
                if (ortalama < 60)
                {
                    durum = "SINIFTA KALDI";
                }
                else
                {
                    durum = "SINIFTAN GE�T�";
                }

                if (ortalama <= 34) { harf = "FF "; }
                if (ortalama >= 35 && ortalama <= 50) { harf = "FD"; }
                if (ortalama >= 51 && ortalama <= 59) { harf = "DD"; }
                if (ortalama >= 60 && ortalama <= 70) { harf = "CC"; }
                if (ortalama >= 71 && ortalama <= 80) { harf = "BC"; }
                if (ortalama >= 81 && ortalama <= 89) { harf = "BB"; }
                if (ortalama >= 90 && ortalama <= 100) { harf = "AA"; }

                cvp = MessageBox.Show("��renci Bilgileri Hesaplans�n M�?", "HESAPLAMA ��LEM�",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    MessageBox.Show("��rencinin Ad� :" + textBox1.Text.Trim() +
                        " " + textBox2.Text.Trim() + "\nOrtalama           :" + Math.Round(ortalama,2) +
                        "\nBa�ar� Durumu :" + durum + "\nHarf Notu          :" + harf);
                    temizle();
                }
                else
                {
                    temizle();
                }
            }

        }

        
    }
}