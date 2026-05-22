using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace UTS_PBO
{
    public class PesanananTakeaway : Pesanankopi
    {
        private double HargaPercup;
        private double BiayaKemasan;
    }
    
    public PesanananTakeaway(string namapelanggan, int jumlahcup, string menukopi, int nomorAntrian, double HargaPercup, double BiayaKemasan) : base(namapelanggan, jumlahcup)
        {
            this.HargaPercup = HargaPercup;
            this.BiayaKemasan = BiayaKemasan;
        }


        public double getHargaPercup()
        {
            return HargaPercup;
        }

        public void setHargaPercup(double HargaPercup)
        {
            this.HargaPercup = HargaPercup;
        }

        public double getBiayaKemasan()
        {
            return BiayaKemasan;
        }

        public void setBiayaKemasan(double BiayaKemasan)
        {
            this.BiayaKemasan = BiayaKemasan;
        }

        public override double HitungTotalBayar()
        {
            return (getjumlahcup() * HargaPercup) + BiayaKemasan;
        }

        public void TampilInfo()
        {
            Console.WriteLine("jenis pesanan + Takeaway");
            Console.WriteLine("Harga Percup + hargaPercup");
            Console.WriteLine("Biaya kemasan + BiayaKemasan");
            Console.WriteLine("Total Bayar + Hitung Total Bayar");
        }
    }     
}
 

