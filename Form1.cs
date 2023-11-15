using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekYonluBaglıList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Dugum
        {
            public int _numara;
            public Dugum _next;

            public Dugum(int numara)
            {
                _numara = numara;
            }


        }

        class CiftDugum
        {
            public string _ad;
            public string _soyad;
            public int _numara;

            public CiftDugum sonraki;
            public CiftDugum onceki;

            public CiftDugum(string ad, string soyad, int numara)
            {
                _ad = ad;
                _soyad = soyad;
                _numara = numara;
            }


        }
            CiftDugum ilk = null;
            CiftDugum son = null;

        private void btnsonaekle_Click(object sender, EventArgs e)
        {
            string girilenad = txtad.Text;
            string girilensoyad = txtsoyad.Text;
            int girilennumara = Convert.ToInt32(txtnumara.Text);

            CiftDugum yeni = new CiftDugum(girilenad, girilensoyad, girilennumara);


            if (ilk == null)
            {
                ilk = yeni;
                ilk.onceki = null;
                ilk.sonraki = null;
                son = ilk;

            }
            else
            {
                CiftDugum gecici = ilk;

                while (gecici != null)
                {
                    gecici = gecici.sonraki;
                }

               
                    son.sonraki = yeni;
                    yeni.onceki = son;
                    yeni.sonraki = null;
                    son = yeni;
                


            }


            txtad.Text = "";
            txtsoyad.Text = "";
            txtnumara.Text = "";
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();


            CiftDugum gecici = ilk;
            int rows = 0;


            while (gecici != null)
            {

                dataGridView.Rows.Add();

                dataGridView.Rows[rows].Cells[0].Value = gecici._ad;

                dataGridView.Rows[rows].Cells[1].Value = gecici._soyad;

                dataGridView.Rows[rows].Cells[2].Value = gecici._numara.ToString();

                rows += 1;

                gecici = gecici.sonraki;

            }
        }
        private void kisisilbul_Click(object sender, EventArgs e)
        {
            int girilennumara = Convert.ToInt32(txtnumara.Text);

            Boolean aynıKodVarmi = false;
            CiftDugum gecici = ilk;

            while (gecici != null)
            {
               
                gecici = gecici.sonraki;
            }

            if (aynıKodVarmi == false)
            {
               
                txtad.Text = "";
                txtsoyad.Text = "";

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndugumsil_Click(object sender, EventArgs e)
        {
            CiftDugum silinecek = ilk;


            int girilenKod = Convert.ToInt32(txtnumara.Text);

            while (silinecek != null)
            {
                if (silinecek._numara == girilenKod)
                {

                    if (silinecek == ilk && ilk.sonraki == null)
                    {
                        ilk = null;

                    }
                    else if (silinecek == ilk)
                    {
                        ilk = ilk.sonraki;
                        ilk.onceki = null;

                    }
                    else if (silinecek == son)
                    {
                        son = son.onceki;
                        son.sonraki = null;
                    }
                    else
                    {
                        silinecek.onceki.sonraki = silinecek.sonraki;
                        silinecek.sonraki.onceki = silinecek.onceki;
                    }


                }

                silinecek = silinecek.sonraki;
            }

            
            txtnumara.Text = "";
        }
    }
}
