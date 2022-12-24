using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] kayitNo = new int[15];
        string[] ad = new string[15];
        string[] soyad = new string[15];
        string[] telefon = new string[15];
        int i = 0, no = 1, sayac = 1;

        private void btn_kayit_giris_Click(object sender, EventArgs e)
        {
            panel_ekle.Visible = true;
            panel_liste.Visible = false;
            panel_ara.Visible = false;
            panel_sil.Visible = false;
            textBox_Kn.Text = sayac.ToString();
        }

        private void btn_kayit_silme_Click(object sender, EventArgs e)
        {
            panel_sil.Visible = true;
            panel_ekle.Visible = false;
            panel_liste.Visible = false;
            panel_ara.Visible = false;
        }

        private void btn_kayit_arama_Click(object sender, EventArgs e)
        {
            panel_ara.Visible = true;
            panel_ekle.Visible = false;
            panel_liste.Visible = false;
            panel_sil.Visible = false;
        }

        private void btn_kayit_listeleme_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = true;
            panel_ekle.Visible = false;
            panel_ara.Visible = false;
            panel_sil.Visible = false;

            listBox1.Items.Clear();
            for (int l = 0; l < i; l++)
            {
                listBox1.Items.Add(kayitNo[l] + "\t\t" + ad[l] + "\t\t" + soyad[l] + "\t\t" + telefon[l]);
            }
        }

        private void btn_kapat1_Click(object sender, EventArgs e)
        {
            panel_ekle.Visible = false;
        }

        private void btn_kapat2_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = false;
        }

        private void btn_kapat3_Click(object sender, EventArgs e)
        {
            panel_ara.Visible = false;
        }

        private void btn_kapat4_Click(object sender, EventArgs e)
        {
            panel_sil.Visible = false;
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int a = 0; a < 15; a++)
            {
                if (textBox_ara.Text == kayitNo[a].ToString())
                    listBox2.Items.Add(kayitNo[a] + "\t\t" + ad[a] + "\t\t" + soyad[a] + "\t\t" + telefon[a]);
            } 
        }

        int[] copKayitNo = new int[15];
        string[] copAd = new string[15];
        string[] copSoyad = new string[15];
        string[] copTelefon = new string[15];
        private void btn_sil_Click(object sender, EventArgs e)
        {
            for (int s = 0; s < 15; s++)
            {
                if (textBox_sil.Text != kayitNo[s].ToString())
                {
                    copKayitNo[s] = kayitNo[s];
                    copAd[s] = ad[s];
                    copSoyad[s] = soyad[s];
                    copTelefon[s] = telefon[s];
                }
                else
                {
                    copKayitNo[s] = 0;
                    copAd[s] = "--------";
                    copSoyad[s] = "--------";
                    copTelefon[s] = "------------";
                }
            }
            textBox_sil.Text = "";
            MessageBox.Show("...Kayıt Silindi...");
            for (int s = 0; s < 15; s++)
            {
                    kayitNo[s] = copKayitNo[s];
                    ad[s] = copAd[s];
                    soyad[s] = copSoyad[s];
                    telefon[s] = copTelefon[s];
            }  
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            kayitNo[i] = no;
            ad[i] =textBox_ad.Text;
            soyad[i] = textBox_soyad.Text;
            telefon[i] = textBox_telefon.Text;
            i++;
            no++;
            sayac++;
            textBox_Kn.Text = sayac.ToString();
            textBox_ad.Text = "";
            textBox_soyad.Text = "";
            textBox_telefon.Text = "";  
        }      
    }
}
