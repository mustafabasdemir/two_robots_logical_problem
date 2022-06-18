using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorun
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerekli değişkenler 
            bool parasüt_durum = false, karsilasma = false;
            int robot1_konum = 0, robot2_konum = 0, robot1_parasüt_konum = 0, robot2_parasüt_konum = 0;

            int[] düzlem = new int[10];   // tek boyutlu düzleme örnek olarak bir dizi oluşturdum.  

            for (int i = 0; i < 10; i++)
            {
                düzlem[i] = i;
                // düzlem içerisindeki konumları belirtmek amacıyla 10 elemanlı dizi açıp içerisine sayılar yerleştirdim
            }

            Random rastgele = new Random();   //robotların düzlem üzerindeki rasgele konumları için random 2 adet sayı oluşturacağım 
            int konum1 = rastgele.Next(10);
            int konum2 = rastgele.Next(10);

            robot1_konum = düzlem[konum1];  // robotun konumu dizinin rasgele secilen indisi olacak  
            robot2_konum = düzlem[konum2];

            robot1_parasüt_konum = düzlem[konum1];  // paraşütler secilen bu indislerde kalacak ve konumu değişmeyecek  
            robot2_parasüt_konum = düzlem[konum2];



            //konum ve paraşüt bilgilerini ekrana yazdıralım 
            Console.WriteLine("1. Robotun paraşütü  düzlem üzerindeki rasgele konumu : " + robot1_konum);
            Console.WriteLine("1. Robotun düzlem üzerindeki rasgele konumu : " + robot1_konum + "\n");
            Console.WriteLine("2. Robotun düzlem üzerindeki rasgele konumu : " + robot2_konum);
            Console.WriteLine("2. Robotun paraşütü  düzlem üzerindeki rasgele konumu : " + robot2_konum + "\n");


            /// işlemler 
            /// 

            while (true)
            {
                if (konum1 < 10)   // adınların belirlenen dizi dısına cıkmaması için kosul koydum  
                {
                    konum1 = konum1 + 1;

                    Console.WriteLine("1. Robot düzlem üzerinde bir adım sola hareket etti. Yeni Konumu : " + konum1);

                    if (konum1 == robot2_parasüt_konum) //her bir adım sola ilerlediğinde bulunduğu konumda paraşüt olduğunu kontrol eden koşul.
                    {
                        Console.Write("1. Robot 2.robotun paraşütünü buldu.  1. robot artık birim zamanda 2x adım atacak \n ");
                    }

                }
                if (konum2 < 10)
                {
                    konum2 = konum2 + 1;
                    Console.WriteLine("2. Robot düzlem üzerinde bir adım sola hareket etti. Yeni Konumu : " + konum2);
                    if (konum2 == robot1_parasüt_konum)
                    {
                        Console.Write("2. Robot 1.robotun paraşütünü buldu.  2. robot artık birim zamanda 2x adım atacak \n");
                    }
                }

            }




            Console.ReadKey();
        }
    }
}
