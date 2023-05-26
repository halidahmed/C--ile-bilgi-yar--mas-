using System;

namespace CSbilgiyarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***************************");
            Console.WriteLine("Bilgi Yarışması: ");

            //kullanıcıdan kişisel bilgilerini isteme
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Cevapları Büyük Harfle Giriniz");
            Console.WriteLine("Sorulara Geçmek İçin Herhangi bir Tuşa basınız...");
            Console.ReadKey();
            Console.Clear();

            //Sorular:
            int ds = 0, ys = 0;

            Console.WriteLine("1.Soru: \nTürkiye cumhuriyetinin kuruluş Tarihi nedir?");
            Console.Write("A)1923 \nB)1988 \nC)1893 \nD)1932 \nCevabınız: ");
            string c1 = Console.ReadLine();
            if(c1=="A")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("2.Soru: \nTürkiyenin başkenti neresidir? ");
            Console.Write("A)Bursa \nB)Ankara \nC)İstanbul \nD)İzmir \nCevabınız: ");
            string c2 = Console.ReadLine();
            if(c2=="B")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
                
            }
            else
            {
                Console.WriteLine("Cevabınız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("3.Soru: \nMaki hangi bölgenin bitki örtüsüdür?");
            Console.Write("A)Akdeniz \nB)Marmara \nC)Ege \nD)Karadeniz \nCevabınız: ");
            string c3 = Console.ReadLine();
            if (c3 == "A")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine(" 4.Soru: \nFetih Sultan Mehmet Kaçıncı osmanlı Padişahıdır?");
            Console.Write("A)1 \nB)3 \nC)7 \nD)10 \nCevabınız:");
            string c4 = Console.ReadLine();
            if (c4 == "C")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("5.Soru: \nMetehandan sonra tahta geçen Türk Kağanı kimdir?");
            Console.Write("A)Çiçi Kağan \nB)İşbara Kağan \nC)İstemi Yabgu Kağan \nD)Ki-ok Kağan \nCevabınız: ");
            string c5 = Console.ReadLine();
            if (c5 == "D")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("6.Soru: \nİstiklal Marşı şairimiz kimdir?");
            Console.Write("A)Nazım HİKMET \nB)Ziya GÖKALP \nC)Mehmet Akif ERSOY \nD)Cemal SÜREYYA \nCevabınız: ");
            string c6 = Console.ReadLine();
            if (c6 == "C")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("7.Soru: \nHangisi marmaranın şehirlerinden birisi değildir?");
            Console.Write("A)Adana \nB)Bursa \nC)İstanbul \nD)Kocaeli \nCevabınız: ");
            string c7 = Console.ReadLine();
            if (c7 == "A")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("8.Soru: \nHangisi RGB renklerinden birisi değildir?");
            Console.Write("A)Mavi \nB)Sarı \nC)kırmızı \nD)Yeşil \nCevabınız: ");
            string c8 = Console.ReadLine();
            if (c8 == "B")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("9.Soru: \n?Göktürk Kağanlığının Kurucusu kimdir?");
            Console.Write("A)İstemi Yabgu Kağan \nB)Bumin Kağan \nC)Mukan Kağan \nD)Taspar Kağan \nCevabınız: ");
            string c9 = Console.ReadLine();
            if (c9 == "B")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            Console.WriteLine("10.Soru: \nİstanbulu İlk Kuşatan Türk Kağanı Kimdir?");
            Console.Write("A)Balamir Kağan \nB)Tardu Kağan \nC)Bayan Kağan \nD)Çiçi Kağan \nCevabınız: ");
            string c10 = Console.ReadLine();
            if (c10 == "C")
            {
                Console.WriteLine("Cevabınız Doğru");
                ds++;
            }
            else
            {
                Console.WriteLine("Cevabız Yanlış");
                ys++;
            }
            Console.WriteLine();

            //doğru sayısıyla ödülü hesaplama:
            int odul = 0;
            for(int i=0; i<ds; i++)
            {
                odul = odul + 1000;
            }

            //Sonuçlar
            Console.WriteLine("Yarışma Sonuçları:");
            Console.WriteLine("Yarışmacı Adı: " + ad);
            Console.WriteLine("Yarışmacı Soyadı: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + ds);
            Console.WriteLine("Yanlış Sayısı: " + ys);
            Console.WriteLine("Ödül: " + odul);

        }
    }
}
