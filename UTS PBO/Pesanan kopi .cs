using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UTS_PBO
{
    public abstract class Pesanankopi
    {
        private string namapelanggan;
        private int nomorantrian;
        private string menukopi;
        protected int jumlahcup;

        // constructor 
        public Pesanankopi(string namapelanggan, int nomorantrian, string menukopi, int jumlahcup)
        {
            this.namapelanggan = namapelanggan;
            this.nomorantrian = nomorantrian;
            this.menukopi = menukopi;
            this.jumlahcup = jumlahcup;
        }

        protected Pesanankopi(string namapelanggan, int jumlahcup)
        {
            this.namapelanggan = namapelanggan;
            this.jumlahcup = jumlahcup;
        }

        // getter set dan setter 
        public string getnamapelanggan() {
            return namapelanggan;
        }

        public void setnamapelanggan()
        {
            this.namapelanggan = namapelanggan;
        }

        public int getnomorantrian() {
            return nomorantrian;
        }

        public void setnomorantrian()
        {
            this.nomorantrian = nomorantrian;
        }

        public String getmenukopi() {
            return menukopi;
        }

        public void setmenukopi()
        {
            this.menukopi = menukopi;
        }

        public int getjumlahcup() {
            return jumlahcup;
        }

        public void setjumlahcup()
        {
            this.jumlahcup = jumlahcup;
        }

        public void tampilinfo()
        {
            Console.WriteLine("Nama Pelanggan : " + namapelanggan);
            Console.WriteLine("Nomor Antrian : " + nomorantrian);
            Console.WriteLine("Menu Kopi : " + menukopi);
            Console.WriteLine("Jumlha cup : " + jumlahcup);
        }

        public abstract double HitungTotalBayar();
    }       

}


    
       




    
