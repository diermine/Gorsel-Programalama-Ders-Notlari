using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks.Sources;
using System.Collections;

//dizi15();
//dizi_16();
//dizi_17();
//dizi_18(); 
//dizi_19();
//dizi_20();
//dizi_21();
//dizi_22();
arraylist_1();
static void dizi15()
{
    string[] adsoyad = new string[2];
    adsoyad[0] = "burak";
    adsoyad[1] = "ayşe";
    Console.WriteLine("dizinin ilk elemanı: "+adsoyad[0]);
    //adsoyad= new string[3];//diziyi yeniden boyutlandırma, veri kaybı yaşanır
    Array.Resize(ref adsoyad, 3);//Array.Resize(ref dizi_adı, yeni boyut(int)) veri    kaybı yaşanmaz
    adsoyad[2] = "emin";
    Console.WriteLine("dizinin ilk elemanı: " + adsoyad[0]);
    Console.WriteLine("dizinin ilk elemanı: " + adsoyad[2]);
}
static void dizi_16()
{//CreateInstance metodu: değişken tipini ve eleman sayısını belirterek tanımlamak için kullanılır

    //tanımladığımız değişken bir nesne olarak geriye döner, tekrar diziye dönüştürülmeli

    Array okulturu = Array.CreateInstance(typeof(string), 3);
    string[] okul = (string[])okulturu;
    okul[0] = "lise";
    okul[1] = "orta öğretim";
}
//IsArray: bir değişkenin dizi olup olmadığını anlamak için kullanılan metot geriye true false döner

static void dizi_17()
{
    string[] okul = { "lise", "orta öğretim" };
    string ad = "burak";
    Type t;
    t = okul.GetType();
    Console.WriteLine("dizi ise: " + t.IsArray);
    t = ad.GetType();
    Console.WriteLine("dizi değil ise: " + t.IsArray);
}
static void dizi_18()
{//SetValue - GetValue
    Array diller = Array.CreateInstance(typeof(string), 2, 2);
    diller.SetValue("C#", 0, 0);
    diller.SetValue("Python", 0, 1);
    diller.SetValue("C++", 1, 0);
    diller.SetValue("ASP", 1, 1);
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine(diller.GetValue(i, j));
        }
    }
}
/*Copy metodu
Array.Copy(kaynak_dizi, hedef_dizi, eleman_sayısı);
Array.Copy(kaynak_dizi, kaynak_indis, hedef_dizi, hedef_indis, eleman_sayısı);
*/
static void dizi_19()
{
    Array diller1 = Array.CreateInstance(typeof(string), 5);
    Array diller2 = Array.CreateInstance(typeof(string), 5);
    diller1.SetValue("C#", 0);
    diller1.SetValue("Python", 1);
    diller1.SetValue("C++", 2);
    diller2.SetValue("ASP", 0);
    diller2.SetValue("BASIC", 1);
    diller2.SetValue("DELPHI", 2);
    diller2.SetValue("PHP", 3);
    //Array.Copy(diller2, diller1, 2);
    Array.Copy(diller2, 1, diller1, 3, 2);
    Console.Read();
}
/*Contains: aranan değer dizide varsa True, yoksa False döndürür*/
static void dizi_20()
{
    string[] ad = { "ayşe", "burak", "emin", "beyza" };
    Console.Write("Aranılan ismi giriniz: ");
    string aranan = Console.ReadLine();
    if (ad.Contains(aranan)==true)
    {
        Console.WriteLine("aranan değer dizide var!");
    }
    else
    {
        Console.WriteLine("aranan değer dizide yok!");
    }
}
/*IndexOf: aranan değer mevcut ise indisini yoksa -1 döndürür*/
static void dizi_21()
{
    string[] ad = { "ayşe", "burak", "emin", "beyza" };
    int index;
    Console.Write("Aranılan ismi giriniz: ");
    string aranan = Console.ReadLine();
    index = Array.IndexOf(ad, aranan);
    if (index==-1)
    {
        Console.WriteLine("aranan değer dizide yok!");
    }
    else
    {
        Console.WriteLine("aranan değer dizide var, indisi: "+index);
    }
}
/*LastIndexOf: aranan eleman dizi içerisnde 1den fazla kez tekrar etmişse en büyük
indisi olan elemanın indisini döndürür*/
static void dizi_22()
{
    string[] ad = { "ayşe", "burak", "emin", "beyza", "burak", "murat" };
    int index;
    Console.Write("Aranılan ismi giriniz: ");
    string aranan = Console.ReadLine();
    //index = Array.LastIndexOf(ad, aranan);
    index = Array.BinarySearch(ad, aranan);//büyük boyutlu dizilerde daha hızlısonuç verir

    if (index == -1)
    {
        Console.WriteLine("aranan değer dizide yok!");
    }
    else
    {
        Console.WriteLine("aranan değer dizide var, indisi: " + index);
    }
}
/*KOLLEKSİYONLAR
*NON GENERİC
** ArrayList sınıfı: içerisine aktarılan değerlerin boxing işlemi ile nesneye 
dönüştürülerek
*tutulduğu sınıf
*/
static void arraylist_1()
{// Add metodu: eleman eklemek için kullanılır
 //Insert metodu: istenilen yere eleman eklemek için kullanılır
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add(12345);
    isimler.Add(true);
    isimler.Add("mehmet");
    Console.WriteLine(isimler[0]);
    isimler[0] = "aydın";
    Console.WriteLine(isimler[0]);
    Console.WriteLine(isimler[1]);
    isimler.Insert(2, "selçuk");
    Console.WriteLine(isimler[0]);
    Console.WriteLine(isimler[1]);
    Console.WriteLine(isimler[2]);
    Console.WriteLine(isimler[3]);
}