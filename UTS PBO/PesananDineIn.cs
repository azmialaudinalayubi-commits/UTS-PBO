using System;
using System.Collections.Generic;
using System.Text;

namespace UTS_PBO
{
    public class PesananDineIn : Pesanankopi
    {
        private double hargaPercup;
        public PesananDineIn(string namaPelanggan, int nomorAntrian, string menuKopi, int jumlahcup, double hargaPercup) : base(namaPelanggan, nomorAntrian, menuKopi, jumlahcup)
        {
            this.hargaPercup = hargaPercup;
        }

        public double gethargaPercup()
        {
            return hargaPercup;
        }
        
        public void sethargaPercup()
        {
            this.hargaPercup = hargaPercup;
        }

        public double HitungTotalBayar()
        {
            return getjumlahcup () * hargaPercup;
        }

        public void tampilanInfo()
        {
            base.tampilinfo();

            Console.WriteLine("jenis pesanan : Dine in");
            Console.WriteLine("Harga Percup : + hargaPercup");
            Console.WriteLine("Total Bayar : + HitungTotalBayar");
        }
    }     
}
