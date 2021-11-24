using System;

namespace Zadanie_vvedenie_v_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество значение градусов угла, затем нажмите Enter");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество значение минут угла, затем нажмите Enter");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество значение секунд угла, затем нажмите Enter");
            int s = Convert.ToInt32(Console.ReadLine());
            Ugol p = new Ugol(g, m, s);
            p.ToRadians();

            Console.WriteLine("Спасибо, что использовали нашу программу, для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

    class Ugol
    {
        int gradus;
        int minut;
        int secund;
        public int Gradus
        {
                set{ 
                 if (value > 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов введено некорректно");
                }
                }
            get
            {
                return gradus;
            }

        }
        public int Minut
        {
            set{
                if (value > 0 && value < 60)
                {
                    minut = value;
                }
                else
                {
                    Console.WriteLine("Значение угловых минут введено некорректно");
                }
            }
            get
            {
                return minut;
            }
        }
        public int Secund
        {
            set {
                if (value > 0 && value < 60)
                {
                    secund = value;
                }
                else
                {
                    Console.WriteLine("Значение угловых секунд введено некорректно");
                }
            }
            get
            {
                return secund;
            }

        }
        public void ToRadians()
        {
            Convert.ToDouble(gradus);
            Convert.ToDouble(minut);
            Convert.ToDouble(secund);
            double rad = ((gradus + (minut / 60) + (secund / 3600)) * Math.PI) / 180;
            Console.WriteLine("Значение угла в радианах равно {0:f2}", rad);
        }
        public Ugol (int gr, int min, int sec)
        {
            gradus = gr;
            minut = min;
            secund = sec;
        }

    }









        }




    }
      

        
    
    


