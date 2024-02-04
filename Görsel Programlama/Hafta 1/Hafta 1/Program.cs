using System.Threading.Tasks.Sources;

//ornek1();
//ornek2();
//ornek3();
//ornek4();
//ornek5();
Console.Read();
static void ornek1()
{
    Console.WriteLine("Hello World!");
}
static void ornek2()
{//string ifadeleri ekrana yazma ve ekrandan okuma
    string ad, soyad;
    Console.Write("Adınızı Giriniz:");
    ad = Console.ReadLine();
    Console.WriteLine("Soyadınızı Giriniz: ");
    soyad=Console.ReadLine();
    Console.WriteLine(ad+" "+soyad);
}
static void ornek3()
{//basit sayısal ifadeleri ekrana yazma ve ekrandan okuma
    int sayi1, sayi2, toplam = 0;
    Console.Write("Birinci sayıyı giriniz: ");
    sayi1=Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayıyı giriniz: ");
    sayi2= Convert.ToInt32(Console.ReadLine());
    toplam = sayi1 + sayi2;
    //Console.WriteLine(toplam);
    //yer tutucu
    //Console.Write("{0} ile {1} sayılarının toplamı {2}", sayi1, sayi2, toplam);
    Console.WriteLine("{0}+{1}={2}", sayi1, sayi2, toplam);
}
/*
***Değişken isimi tanımlanırken dikkat edilecekler***
*C#'ta büyük-küçük harf ayrımı vardır.
*değişken isimleri mutlaka harf yada _ karakteri ile başlamalı
*değişken isimlerinde boşluk bulunamaz
*özel karakterler içeremez ()!'^+&/+;
*özetle sadece harf, rakam, _ kullanılabilir(rakam başta olmamak kaydıyla)
*max 255 karakterden oluşabilir.
*C# için anlamlı olan ifadeler kullanılamaz
*/
/*
**Operatörler
* + sayısal tiplerde toplama, string tiplerde birleştirme
* - çıkarma işlemi
* * çarpma işlemi
* / bölme işlemi
* % mod alma işlemi(bölümden kalan)
* ++ sayısal değerleri 1 arttırmak için kullanılır
* -- sayısal değerleri 1 eksiltmek için kullanılır
* ikişer, üçer, dörder.... arttırmak için (a+=2, a+=3, a+=4....)
* 
* 
* **Aktarma operatörleri
* = eşitliğin sağındaki değeri solundaki değişkene aktarır
* += ,-= , *= , /= her seferinde değişkenin sonucunu eşitliğin sağındaki 
ifadeye ekler çıkarır çarpar böler
* 
* 
* ** Mantıksal Operatörler
* &(ve): iki tarafındaki şartlar doğru ise TRUE döner(a<2 & a>0)
* &&(Kısa devre ve): şartın uymadığı ilk noktada FALSE döndürür.
* | (veya): şartlardan herhangi biri doğruysa TRUE döner(a<2 | a>2)
* || (kısadevre veya): sartın doğru olduğu ilk anda TRUE döner
* ! (değilleme): ifadenin tersini alır. (!=) bir şarta değilse anlamı yükler
* ?(ternary):"" (şart)? doğru ise yapılacaklar : yanlış ise yapılacaklar ""
* (a>5)? Console.Write("x") : Console.Write("y"); (basit bir if-else yapısıdır)
* 
* ?(nullable): değişken veri tipinden sonra kullanılırsa o değişkenin NULL 
bırakılamayacağını belirtir
* int? sayi=0;
* 
* 
* ** Karşılaştırma Operatörleri
* == eşitliğin sağındaki değerle solundaki değer eşit ise TRUE, farklı ise 
FALSE döner
* != eşitliğin sağındaki değer ile solundaki değer eşit değilse TRUE, aynı ise 
FALSE döner
* < > >= <= 
*
*/
static void ornek4()
{
    int i = 0, j = 0, top = 0;
    i = ++j;
    //i = j++;
    top = i + j;
    Console.Write(top);
}
static void ornek5()
{
    int a, x = 1, y = 2;
    Console.Write("Bir sayı giriniz: ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((a < 0) ? "sayı negatif" : "sayı pozitif");
    Console.WriteLine(x < y && y < x);
    Console.WriteLine(x < y || y < x);
    Console.WriteLine(x == y);
    Console.WriteLine(x!=y);
    Console.WriteLine(x+=y);
}
/*
** Veri Tipleri
*
*Sayısal veri tipleri
**tam sayı veri tipleri
*byte 0:255
*sbyte -128:127
*short: -32 bin :+32 bin
*ushort: 0: 64bin
*uint: 0: 4milyar
*int: -2 milyar: +2 milyar
*ulong: 0: 9,223,...,...,...,...,...
*long: ......
*en çok kullanılan byte, int, long
*
**ondalıklı veri tipleri
*float: 4 byte
*double: 8 byte
*decimal: 16 byte
*
*
*mantıksal veri tipi
*bool: 4 byte iki değer alır true/false
*
*tarih saat veri tipi
*datetime 8 byte 01.01.0001 - 31.12.9999
*
***karakter veri tipleri
*string: uzunluğu içerisinde saklanan karakter boyutu kadar
*formül: (20+(n/2)*4) bit( n karakter sayısı)
*
*/