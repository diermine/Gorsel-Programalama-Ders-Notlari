using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks.Sources;
using System.Collections;


//dizi_9();
//dizi_10();
//dizi_11();  
//dizi_12();
//dizi_13();
dizi_14();

static void dizi_9()
{
    int[] x = { 25, 3, 5, 85, 88, 95, 20, 65, 45, 1 };
    int i, j, temp, min;
    for (i = 0; i < x.Length; i++)
    {
        min = i;
        for (j = i+1; j < x.Length; j++)
        {
            if (x[j] < x[min]) min = j;
        }
        temp = x[i];
        x[i]= x[min];
        x[min] = temp;
    }
    foreach (int k in x)
    {
        Console.WriteLine(k);
    }
}
static void dizi_10()
{/*10 elemanlı bir x dizisinin elemanlarından tek olanları y dizisine 0. 
indisten, çift olanları
 son indisten başlayarak yazan...*/
    int[] x = { 45, 24, 66, 12, 48, 84, 53, 69, 91, 14 };
    int[] y = new int[x.Length];
    int t = 0, c = x.Length - 1;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i]%2==0)
        {
            y[c] = x[i];
            c--;
        }
        else
        {
            y[t] = x[i];
            t++;
        }
    }
    foreach (var item in y)
    {
        Console.WriteLine(item);
    }
}
/*iki diziyi rasgele eşleştirme, öğretmen ataması, çekiliş*/
static void dizi_11()
{
    string[] sehirler = { "ankara", "istanbul", "izmir", "edirne", "kırklareli",
"van", "erzurum" };
    string[] isimler = { "volkan", "burak", "emin", "beyza", "ayşe", "bilal",
"leyla" };
    Random rnd = new Random();
    bool[] kontrol = new bool[7];
    int sayi;
    for (int i = 0; i < kontrol.Length; i++)
    {
        do
        {
            sayi = rnd.Next(0, 7);
        } while (kontrol[sayi]==true);
        kontrol[sayi] = true;
        Console.WriteLine("{0}-->{1}", sehirler[i], isimler[sayi]);
    }
}
static void dizi_12()
{ /*1-10 arası rasgele 1000 üretiken sayılardan hangisinde kaç adet 
üretilediği*/
    Random rnd = new Random();
    int sayi;
    int[] x = new int[10];
    for (int i = 0; i < 1000; i++)
    {
        sayi=rnd.Next(1, 11);
        x[sayi - 1]++;
    }
    for (int j = 0; j < x.Length; j++)
    {
        Console.WriteLine("{0}-->{1}", j + 1, x[j]);
    }
}
static void dizi_13()
{
    /*dizinin 1. elemanına en yakın değeri olan elemanı bulan...*/
    int[] x = { 21, 20, 50, 22, 12, 100, 65, 75, -5, 9 };
    int ey = 1;
    for (int i = 2; i < x.Length; i++)
    {
        if (Math.Abs(x[0] - x[i]) < Math.Abs(x[0] - x[ey]))
        {
            ey = i;
        }
    }
    Console.Write("1. sayıya en yakın sayı: " + x[ey]);
}
/*alıştırma sorusu
*
*dizide birbirine en yakın olan iki sayıyı bulan C# kodunu yazınız.
*
*/
static void dizi_14()
{/*9 elemanlı bir diziyi 3erli gruplara ayırma..*/
    string[] isimler = { "volkan", "burak", "emin", "beyza", "ayşe", "bilal",
"leyla","murat","ali" };
    bool[] kontrol = new bool[9];
    Random rnd = new Random();
    int sayi;
    for (int i = 0; i < isimler.Length; i++)
    {
        do
        {
            sayi = rnd.Next(0, 9);
        } while (kontrol[sayi]==true);
        kontrol[sayi] = true;
        Console.Write(isimler[sayi] + " ");
        if ((i + 1) % 3 == 0) Console.WriteLine();
    }
}