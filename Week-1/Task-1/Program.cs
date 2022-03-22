using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ödev-1
             * Deprem ve zemin parametrelerini kullanarak en büyük yatay yer ivmesinin 
             * belirlenmesini sağlayan yüksek lisans tezimde oluşturduğum ampirik bağıntıyı çalıştıran program.
             */
            
            Console.WriteLine("ZE: ");
            double ZE=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mw(5+): ");
            double Mw=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rhypo(km): ");
            int Rhypo=int.Parse(Console.ReadLine());
            Console.WriteLine("Vs30: ");
            int Vs30=int.Parse(Console.ReadLine());
            Console.WriteLine("Vp30: ");
            int Vp30=int.Parse(Console.ReadLine());

            double A1= 0.621;
            double A2= -1.179;
            double A3= -0.081;
            double log=Math.Log10(Rhypo);
            double Vv=Vp30/Vs30;


            double top= A1*Mw+A2*log+A3*Vv;

            double formula1= Math.Pow(10, top);
            double a= formula1*ZE;

            Console.WriteLine("Yatay yer ivmesi: " + a);





        }
    }
}
