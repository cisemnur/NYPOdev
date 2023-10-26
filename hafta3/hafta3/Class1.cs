using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
    internal class personel
    {
        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;
        }

        string adres;
        public string Adres
        {
            get => adres;
            set => adres = value;
        }
        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;}
        int mesaı;
        public int Mesaı
        {
            get => yas;
            set => yas = value;

        }
        string unvan;
        public string Unvan
        { get => unvan;
        set => unvan = value; }

        public personel (string gAd,string gAdres,int gYas,int gMesaı, string gUnvan)
        { this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesaı = gMesaı;
            this.Unvan = gUnvan;
        }
           public int ucrethesapla()
        { 
            return this.Mesaı * 100; 
        }

        public void ucrethesapla(int ekUcret)
        {
            MessageBox.Show((this.mesaı * 100 + ekUcret).ToString());
        }
     }    

}
    
