using System.Threading.Tasks.Sources;
//ornek6();
//ornek7();

//Kont_1();
//Kont_2();
//Kont_3();

//Dongu_1();
//Dongu_2();
//Dongu_3();
//dongu_4();
//dongu_5();

static void ornek6()
{
    int yil;
    Console.Write("Doğum yılınızı giriniz: ");
    yil=Convert.ToInt32(Console.ReadLine());
    Console.Write("Yaşınız: "+ (DateTime.Now.Year - yil));
}
static void ornek7()
{
    Console.WriteLine("Bir tuşa basınız!");
    System.ConsoleKeyInfo tus = Console.ReadKey(true);
    Console.Write(tus.Key.ToString()+" tuşuna bastınız!");
}
static void Kont_1()
{//Kontrol deyimleri: if-else, if-elseif-else, switch-case
    Console.Write("Bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi==5)
    {
        Console.Write("Sayı 5tir");
    }
    else if (sayi < 5)
    {
        Console.Write("Sayı 5ten küçüktür!");
    }
    else
    {
        Console.Write("Sayı 5ten büyüktür!");
    }
}
static void Kont_2()
{
    int not;
    Console.Write("Notu giriniz: ");
    not = Convert.ToInt32(Console.ReadLine());
    if (not<0 || not>100)
    {
        Console.Write("0-100 aralığında bir not giriniz!");
    }
    else
    {
        if (not<40) { Console.Write("FF"); }
        else if (not>=40 && not <=51) { Console.Write("DD"); }
        else if (not >= 40 && not <= 51) { Console.Write("DC"); }
        else if (not >= 52 && not <= 63) { Console.Write("CC"); }
        else if (not >= 64 && not <= 75) { Console.Write("CB"); }
        else if (not >= 76 && not <= 80) { Console.Write("BB"); }
        else if (not >= 81 && not <= 88) { Console.Write("BA"); }
        else { Console.Write("AA"); }
    }
}
static void Kont_3()
{
    int sayi1, sayi2;
    string oprt;
    Console.Write("İlk sayıyı giriniz: ");
    sayi1= Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayıyı giriniz: ");
    sayi2= Convert.ToInt32(Console.ReadLine());
    Console.Write("+,-,*,/ operatörlerinden birini giriniz: ");
    oprt= Console.ReadLine();
    switch (oprt)
    {
        case "+": { Console.Write("Sonuç: " + (sayi1 + sayi2)); break; }
        case "-": { Console.Write("Sonuç: " + (sayi1 - sayi2)); break; }
        case "*": { Console.Write("Sonuç: " + (sayi1 * sayi2)); break; }
        case "/": { Console.Write("Sonuç: " + (sayi1 / sayi2)); break; }
        default: { Console.Write("Yanlış bir operatör girdiniz!"); break; }
    }
}
static void Dongu_1()
{//for, while, do-while, foreach
    /*
    döngüler:
    *başlangıç değeri
    *bitiş değeri
    *döngü değişkeni(sayaç), artış yada azalış miktarı
    */
    int toplam = 0, j = 1;
    for (int i = 99; i >=1; i-=2)
    {
        Console.WriteLine("{0}-->{1}", j, i);
        j += 1;
        toplam += i;
    }
    Console.WriteLine("Bu sayılar {0} tane.", j - 1);
    Console.WriteLine("Sayıların toplamı {0}", toplam);
}
static void Dongu_2()
{
    ulong f = 1;
    Console.WriteLine("Sayı gir: ");
    ulong sayi = Convert.ToUInt32(Console.ReadLine());
    for (ulong i = 2; i <=sayi; i++)
    {
        f *= i;//f=f*i;
    }
    Console.WriteLine("Sonuç: " + f);
}
static void Dongu_3()
{
    /*1X1=1
    2x1=2
    .
    .
    .
    10x1=10
    */
    for (int i = 1; i < 11; i++)
    {
        for (int j = 1; j < 11; j++)
        {
            Console.WriteLine("{0}X{1}={2}", j, i, i*j);
        }
        Console.WriteLine();
    }
}
static void dongu_4()
{//kullanıcı 0 girene kadar girdiği tüm sayıları toplayan..
    int toplam = 0, adet = 0, sayi = -1;
    Console.WriteLine("Sayıları giriniz: ");
    while (sayi!=0)
    {
        sayi = int.Parse(Console.ReadLine());
        toplam += sayi;
        adet++;
    }
    Console.WriteLine("{0} adet sayı girdiniz, toplamları: {1}", adet - 1,
   toplam);
}
static void dongu_5()
{//girilen sayıların toplamı 50 olduğunda sonlanan kod..
    int sayi, toplam = 0, adet = 0;
    while (toplam<50)
    {
        Console.Write("Sayı gir: ");
        sayi= int.Parse(Console.ReadLine());
        toplam += sayi;
        adet++;
    }
    Console.WriteLine("{0} adet sayı girdiniz, toplamları: {1}", adet, toplam);
}