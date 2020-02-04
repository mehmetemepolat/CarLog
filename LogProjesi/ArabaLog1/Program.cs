using System;

namespace ArabaLog1
{
    class Program
    {
        static void Main(string[] args)
        {
            char yon;
            int ivme = 0, i = 0;
            do
            {
                yon = Console.ReadKey().KeyChar;
                switch (yon)
                {
                    case 'w': Console.WriteLine(" " + DateTime.Now + " İleri"); break;
                    case 'd': Console.WriteLine(" " + DateTime.Now + " Sağa Dönüş"); break;
                    case 'a': Console.WriteLine(" " + DateTime.Now + " Sola Dönüş"); break;
                    case 's': Console.WriteLine(" " + DateTime.Now + " Yavaşla"); ivme = ivme + 1; break;
                    case 'o':
                        {
                            for (i = 0; i < 3; i++)
                            {
                                Console.Beep();
                                Console.WriteLine(" " + DateTime.Now + " Sağa Sinyal");
                                System.Threading.Thread.Sleep(850);
                            }
                        }
                        break;
                    case 'p':
                        {
                            for (i = 0; i < 3; i++)
                            {
                                Console.Beep();
                                Console.WriteLine(" " + DateTime.Now + " Sola Sinyal");
                                System.Threading.Thread.Sleep(850);
                            }
                        }
                        break;



                }
            } while (ivme != 3);
            if (ivme == 3)
            {
                Console.WriteLine(" Durdu");
            }
        }
    }
}
