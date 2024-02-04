using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks.Sources;
using System.Collections;

//dongu_6();
//dongu_7();
//dongu_8();
//dongu_kirma();

//ornek8();
//ornek9();

sayi_tahmin();
static void dongu_6()
{//faktöriyel hesabı
    int sayi, sayac = 2, f = 1;
    Console.Write("Sayı gir: ");
    sayi=int.Parse(Console.ReadLine());
    while (sayac<=sayi)
    {
        f *= sayac;
        sayac++;
    }
    Console.WriteLine("Girilen sayının faktöriyeli: " + f);
}
static void dongu_7()
{//kullanıcının giridği 5 sayıdan tek olanların adeti..
    int sayi, sayac = 0, adet = 0;
    while (sayac<5)
    {
        Console.Write("Sayı gir: ");
        sayi=int.Parse(Console.ReadLine());
        if (sayi%2==1)
        {
            adet++;
        }
        sayac++;
    }
    Console.WriteLine("{0} adet tek sayı girdiniz!", adet);
}
static void dongu_8()
{//do-while kullanıcının girdiği 10 adet sayının tekleri ve çiftleri toplamlarını
    int sayi, sayac=0, tekT=0, ciftT=0, adetT=0, adetC = 0;
    do
    {
        Console.Write("Sayı gir: ");
        sayi = int.Parse(Console.ReadLine());
        if (sayi%2==0)
        {
            ciftT += sayi;
            adetC++;
        }
        else
        {
            tekT += sayi;
            adetT++;
        }
        sayac++;
    } while (sayac<10);
    Console.WriteLine("{0} adet çift sayının toplamı: {1}", adetC, ciftT);
    Console.WriteLine("{0} adet tek sayının toplamı: {1}", adetT, tekT);
}
/*Döngülerde atlama ve kırma komutları
Continue, Break*/
static void dongu_kirma()
{
    for (int i = 0; i < 10; i++)
    {
        if (i == 5) continue;
        //if (i == 5) break;
        Console.WriteLine(i);
    }
}
static void ornek8()
{//Random nesnesi rasgele sayılar üretmek için kullanılır.
    /*0-100 arasında 0 üretilene kadar üretilen sayıların adet ve toplamı*/
    Random rnd = new Random();
    int sayi = 1, toplam = 0, adet = 0;
    while (sayi!=0)
    {
        adet++;
        sayi = rnd.Next(0, 101);
        toplam += sayi;
        Console.WriteLine("{0}-->{1}", adet, sayi);
    }
    Console.WriteLine("{0} adet sayı üretildi, toplamları {1}", adet, toplam);
}
static void ornek9()
{//1-10 arasında rasgele üretilen sayıların toplamı 100 oluncaya kadar ki adeti..
    Random rnd = new Random();
    int sayi, toplam = 0, adet = 0;
    while (toplam < 100)
    {
        sayi = rnd.Next(1, 11);
        adet++;
        toplam+= sayi;
        Console.WriteLine("{0}-->{1}", adet, sayi);
    }
    Console.WriteLine("{0} adet sayı üretildi, toplamları {1}", adet, toplam);
}
static void sayi_tahmin()
{
    int tahmin, tutulan;
    String tercih;
    Random rnd = new Random();
    do
    {
        int hak = 10;
        tutulan = rnd.Next(1, 101);
        Console.WriteLine("Tahmininiz: ");
        while (hak>0)
        {
            hak--;
            tahmin=int.Parse(Console.ReadLine());
            if (tutulan==tahmin)
            {
                Console.WriteLine("Tebrikler!");
                break;
            }
            else if (tahmin < tutulan)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz!");
            }
            else
            {
                Console.WriteLine("Daha küçük bir sayı giriniz!");
            }
        }
        Console.WriteLine("Tutulan sayı: " + tutulan);
        Console.WriteLine("Tekrar oynamak ister misiniz?(e/h)");
        tercih=Console.ReadLine();
    } while (tercih=="e" || tercih=="E");
}
