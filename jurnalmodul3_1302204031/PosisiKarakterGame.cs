using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul3_1302204031
{
    internal class PosisiKarakterGame
    {
        enum State { Berdiri, Tengkurap };

        public void posisi()
        {
            State kondisi = State.Berdiri;
            string[] menu = { "Berdiri", "Tengkurap" };
            Console.WriteLine("Posisi standby");
            while (kondisi != null)
            {//Dewa_Arjuna_1302204031
                Console.WriteLine("Menu " + menu[(int)kondisi]);
                Console.Write("Masukkan perintah : ");
                string perintah = Console.ReadLine();
                switch (kondisi)
                {//Dewa_Arjuna_1302204031
                    case State.Berdiri:
                        if (perintah == "standby")
                        {
                            kondisi = State.Berdiri;
                            Console.WriteLine("Posisi standby");
                        }
                        else if (perintah == "tengkurap")
                        {
                            Console.WriteLine("posisi istirahat");
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }//Dewa_Arjuna_1302204031
                        break;
                    case State.Tengkurap:
                        if (perintah == "tengkurap")
                        {
                            kondisi = State.Tengkurap;
                            Console.WriteLine("Posisi istirahat");
                        }
                        else if (perintah == "standby")
                        {
                            Console.WriteLine("Posisi standby");
                        }
                        else
                        {//Dewa_Arjuna_1302204031
                            System.Environment.Exit(1);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
