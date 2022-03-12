using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul3_1302204031
{
    internal class KodeBuah
    {
        //Dewa_Arjuna_1302204031
        string[] namabuah = {"Apel", "Aprikot", "Alpukat", "Pisang", "Paprika","Blackberry","Ceri", "Kelapa", "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka"};
        string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "O00" };

        public void getKodeBuah()
        {//Dewa_Arjuna_1302204031
            int panjang = namabuah.Length;
            for (int i = 0; i < panjang; i++)
            {
                Console.WriteLine(namabuah[i]);
            }
        }
    }
}
