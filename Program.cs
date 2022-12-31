using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
namespace dizi_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {
                sayi = rnd.Next(1, 100);

                a[i] = sayi;
                Console.WriteLine(a[i]);
                Thread.Sleep(500);
            }
            //Dizideki sayıların toplamı ve ortalaması
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam = toplam + a[i];
            }
            Console.WriteLine("Dizi içerisindeki sayıların toplamı= " + toplam);
            Console.WriteLine("Dizi içerisindeki sayıların ortalaması= " + (toplam / 10));

            //Dizideki sayılardan 50'den büyük olanların sayısı            
            int buyuklerin_adeti = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] > 50)
                    buyuklerin_adeti++;
            }
            Console.WriteLine("50'den büyük olanların adeti= " + buyuklerin_adeti);

            //Dizideki sayılardan en büyüğünü ve en küçüğünü bulma  
            int enb = 0, enk = 0;
            enb = a[0]; enk = a[0];
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < enk)
                    enk = a[i];
                if (a[i] > enb)
                    enb = a[i];
            }
            Console.WriteLine("Sayılardan en büyüğü= " + enb);
            Console.WriteLine("Sayılardan en küçüğü= " + enk);

            //Dizideki sayıları küçükten büyüğe sıralama  
            int yedek = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] > a[j])
                    {
                        yedek = a[i];
                        a[i] = a[j];
                        a[j] = yedek;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }
            //Array.Sort(a) ile de küçükten büyüğe doğru sıralayabiliriz

            bool bulundu = false;
            Console.WriteLine("Ara..");
            int aranan= Convert.ToInt32( Console.ReadLine());
            for (int k = 0; k < 10; k++)
            {
                if (a[k] ==aranan)
                {
                    bulundu = true;
                    break;
                }
                else
                {
                    bulundu = false;
                }
            }
            if(bulundu=true)
            {
                MessageBox.Show("Aranan Değer Bulundu!");
            }
            else
            {
                MessageBox.Show("Aranan Değer Bulunamadı!");
            }

            Console.ReadLine();
        }
    }
}
