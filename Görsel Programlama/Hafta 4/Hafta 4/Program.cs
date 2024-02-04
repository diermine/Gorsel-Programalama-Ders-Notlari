using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks.Sources;
using System.Collections;


//dizi_1();
//dizi_2();
//dizi_3();
//dizi_4();
//dizi_5();
//dizi_6();
//dizi_7();
dizi_8();

static void dizi_1()
{
    int[] diziA = new int[51];//51 elemanlı diziA dizisinin tanımlanması
    int j = 0;
    for (int i = 1; i < 101; i+=2)
    {
        diziA[j] = i;
        j++;
    }
    //for (int i = 0; i < 51; i++)
    //{
    // Console.WriteLine(diziA[i]);
    //}
    foreach (int k in diziA)
    {
        Console.WriteLine(k);
    }
}
static void dizi_2()
{//diziler rasgele erişimli veri yapıları
    string[] ad = { "Volkan", "Ayşe", "Beyza", "Emin" };
    //string[] ad2 = new string[10];
    Console.WriteLine(ad[2]);
    foreach (string k in ad)
    {
        Console.WriteLine(k);
    }
}
static void dizi_3()
{
    int[,] x = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
    for (int i = 0; i < x.GetLength(0); i++)//dizinin ilk boyutunun eleman  sayısını getirir

    {
        for (int j = 0; j < x.GetLength(1); j++)//dizinin ikinci boyutunun eleman sayısını getirir

        {
            Console.Write(x[i, j]);
            if (j == x.GetLength(1) - 1) Console.WriteLine();
        }
    }
    //foreach (int k in x)
    //{
    // Console.WriteLine(k);
    //}
}
static void dizi_4()
{
    int[] a = new int[5];
    for (int i = 0; i < a.Length; i++)//a.Length dizinin eleman sayısını getirir
    {
        Console.Write("{0}. sayıyı gir: ", i+1);
        a[i]=int.Parse(Console.ReadLine());
    }
    Console.WriteLine("{0}+{1}={2}", a[2], a[4], a[2] + a[4]);
}
static void dizi_5()
{
    /*10-50 arasında rasgele 10 adet sayıyı diziye aktarıp, 
    * bu sayıların kendilerini ekrana yazan, toplamlarını dizinin son indisine 
   yazan*/
    Random rnd = new Random();
    int[] x = new int[11];
    //int toplam = 0;
    for (int i = 0; i < x.Length-1; i++)
    {
        x[i] = rnd.Next(10, 51);
        Console.WriteLine(x[i]);
        // toplam += x[i];
        x[x.Length - 1] += x[i];
    }
    //x[x.Length-1] = toplam;
    Console.WriteLine();
}
static void dizi_6()
{
    /*dizi içerisinde son rakamı 0 olan elemanların sayısı*/
    int[] x = { 10, 25, 950, 65, 78, 20, 10000 };
    int adet = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 10 == 0) adet++;
    }
    Console.WriteLine("{0} adet sayı vardır!", adet);
}
static void dizi_7()
{
    /*eleman sayısı dışarıdan alınan dizi*/
    int sayi;
    Console.Write("Öğrenci sayısını giriniz: ");
    sayi=int.Parse(Console.ReadLine());
    string[] isim = new string[sayi];
    for (int i = 0; i < isim.Length; i++)
    {
        Console.Write("{0}. öğrencinin adı: ", i + 1);
        isim[i] = Console.ReadLine();
    }
    Console.ReadLine();
}
static void dizi_8()
{
    int[] x = new int[10];
    int temp;
    for (int i = 0; i < x.Length; i++)
    {
        Console.Write("{0}. sayıyı gir: ", i+1);
        x[i]=int.Parse(Console.ReadLine());
    }

Console.WriteLine("Dizinin eleman alımı tamamlandı!");
Console.WriteLine("Dizi ters çevriliyor!");
for (int i = 0; i <= (x.Length-2)/2; i++)
{
    temp = x[(x.Length - 1) - i];
    x[(x.Length - 1) - i] = x[i];
    x[i] = temp;
}
Console.WriteLine("Dizi ters çevirildi!");
foreach (int k in x)
{
    Console.WriteLine(k);
}
Console.WriteLine("Ters çevrilmiş dizi elemanları yazdırıldı!");
}