// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

namespace jurnalmodul3_1302204031
{
    public class Program
    {//Dewa_Arjuna_1302204031
        public static void Main()
        {
            Console.WriteLine("Table-Driven");
            KodeBuah kode = new KodeBuah();
            kode.getKodeBuah();
            Console.WriteLine("\nState-Based");
            PosisiKarakterGame pintu = new PosisiKarakterGame();
            pintu.posisi();
        }
    }//Dewa_Arjuna_1302204031
}