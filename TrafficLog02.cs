using System;

namespace NewLog
{
    class Program
    {
        static void Main(string[] args)
        {
            // when any vehicle arrived at the checkpoint this program will analyze the history of the car and let us know if it obeyed the traffic rules in the past ...test2
            // Kontrol Noktasına gelen aracın sürüş geçmişini analiz edip geçmişinde trafik kurallarına uyup uymadığını analiz edip bize gösteren program denemesi
            // 2 aracın kazası durumunda, kazaya sebebiyet verenin kim/ne olduğunu tespitini sağlayan program denemesi

            Random rast = new Random();

            int Rand = rast.Next(100);
            int ivme=0;
            Console.WriteLine("Kaç M gitsin??");
            try { 
            int maxM = Convert.ToInt32(Console.ReadLine());
           


            do
            {
                char yon=Console.ReadKey().KeyChar;
                int stopR=0,stopL=0;
                
                switch(yon)
                {
                    case 'w': Console.WriteLine(" " + DateTime.Now + " İleri");ivme=ivme+1; break;
                    case 'd': Console.WriteLine(" " + DateTime.Now + " Sağa Dönüş");ivme=ivme+1; break;
                    case 'a': Console.WriteLine(" " + DateTime.Now + " Sola Dönüş"); ivme=ivme+1;break;
                    case 's': Console.WriteLine(" " + DateTime.Now + " Yavaşla"); ivme = ivme -1; break;
                    //sağa sinyal 3 kez çalacak sonra duracak
                    case 'p':
                        {   
                            stopR=stopR+1;
                            if (stopR % 2 == 1) 
                            { 
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(DateTime.Now+"Sağ Sinyal");
                                Console.Beep();
                                System.Threading.Thread.Sleep(850);
                                
                            }
                            }
                        }break;
                        //Sola Sinyal 3 kez çalacak sonra duracak
                    case 'o':
                        {
                            stopL=stopL+1;
                            if(stopL%2==1)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.WriteLine(DateTime.Now+"Sola Sinyal");
                                    Console.Beep();
                                    System.Threading.Thread.Sleep(850);
                                        
                                }
                            }
                        }break;
                        default:Console.WriteLine("El freni ile gitmiyor bu araba  ");break;
                }


        }while(ivme != Rand );
            if (ivme == Rand)
            {
                Console.WriteLine(maxM+"Metre sonra Durdu");
            }
        }
             
            catch(InvalidCastException e)
            { }
        }
    }
}