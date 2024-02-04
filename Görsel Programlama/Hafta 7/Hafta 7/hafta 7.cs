using System.Collections;

//fixedsize referans olarak verilen dizinin boyutunu sabitlemek için kullanılır.

//arraylist2();

//arraylist3();
//arraylist3x1();

//arraylist4();
//arraylist4_1();
//arraylist4_2();
//arraylist4_3();

//arraylist5();

//arraylist6();
//arraylist7();
//arraylist8();

//arraylist9();

//arraylist11();

//ornek1();

ornek2();


/*FixedSize : referans olarak verilen dizinin boyutunu sabitlemek için kullanılır.*/
static void arraylist2()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    Console.WriteLine(isimler[0]);
    Console.WriteLine(isimler[1]);
    Console.WriteLine(isimler[2]);
    ArrayList isimler_2 = ArrayList.FixedSize(isimler);
    //isimler_2[0]="aydın";
    isimler.Insert(0, "aydın");
    Console.WriteLine(isimler[0]);
    Console.WriteLine(isimler[1]);
    Console.WriteLine(isimler[2]);
    Console.WriteLine(isimler[3]);

}

/*Sort: liste sıralamak  için kullanılan metot varsayılan olarak küçükten büyüğe doğru sıralar.*/
/*reverse : listeyi tersine çevirir.*/

static void arraylist3()
{
    ArrayList isimler=new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Sort(); 
    foreach(object k in isimler)
    {
        Console.WriteLine(k); 
    }
}
static void arraylist3x1()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Sort();
    for (int i = 0; i < isimler.Count; i++) 
    {
        Console.WriteLine(isimler[i]);
    }
}

//Remove: değeri bilinen elemanı silmek için kullanılır.
//RemoveAT: indis değeri bilinen elemanı silmek için kullanılır.
//RemoveRange : aralık silme işlemi için kullanılır. RemoveRange(indis, eleman sayısı )
//Clear : dizi içerisindeki bütün elemanları siler.



static void arraylist4()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Add("ahmet");
    isimler.Remove("ahmet");
    for (int i = 0; i < isimler.Count; i++)
    {
        Console.WriteLine(isimler[i]);
    }
}
static void arraylist4_1()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Add("ahmet");
    isimler.RemoveAt(0);
    for (int i = 0; i < isimler.Count; i++)
    {
        Console.WriteLine(isimler[i]);
    }
}
static void arraylist4_2()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Add("ahmet");
    isimler.RemoveRange(1,2);
    for (int i = 0; i < isimler.Count; i++)
    {
        Console.WriteLine(isimler[i]);
    }
}
static void arraylist4_3()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    isimler.Add("mehmet");
    isimler.Add("burak");
    isimler.Add("ahmet");
    isimler.Clear();
    for (int i = 0; i < isimler.Count; i++)
    {
        Console.WriteLine(isimler[i]);
    }
}

//Capacity : liste için bellekte ayrılan yeri gösterir. 4'er artar.

static void arraylist5()
{
    ArrayList isimler = new ArrayList();
    isimler.Add("hasan");
    isimler.Add("ahmet");
    isimler.Add("ayşe");
    Console.WriteLine("Eleman sayısı: " + isimler.Count);
    Console.WriteLine("Kapasite: " + isimler.Capacity);
    isimler.Add("burak");
    Console.WriteLine("Eleman sayısı: " + isimler.Count);
    Console.WriteLine("Kapasite: " + isimler.Capacity);
    isimler.Add("tuna");
    Console.WriteLine("Eleman sayısı: " + isimler.Count);
    Console.WriteLine("Kapasite: " + isimler.Capacity);
}

//GetRange: listenin belirli bir kısmını geriye döndürür.
//AddRange : bir listenin elemanlarını başka bir listeye eklemek için kullanılır.

static void arraylist6()
{
    ArrayList diller=new ArrayList();
    diller.Add("C#");
    diller.Add("Pyhton");
    diller.Add("Java");
    diller.Add("Asp");
    ArrayList diller2 = diller.GetRange(1, 2);
    foreach(object k in diller2)
    {
        Console.WriteLine(k);
    }
}
static void arraylist7()
{
    ArrayList diller = new ArrayList();
    ArrayList diller2 = new ArrayList();
    diller.Add("C#");
    diller.Add("Pyhton");
    diller.Add("Java");
    diller2.Add("Asp");
    diller2.Add("C++");
    diller.AddRange(diller2);
    foreach (object k in diller)
    {
        Console.WriteLine(k);
    }
}

//InsertRange : bir listenin elemanlarını başka bir listeye belirtilen indisten itibaren ekler.

static void arraylist8()
{
    ArrayList diller = new ArrayList();
    ArrayList diller2 = new ArrayList();
    diller.Add("C#");
    diller.Add("Pyhton");
    diller.Add("Java");
    diller2.Add("Asp");
    diller2.Add("C++");
    diller.InsertRange(1,diller2);
    foreach (object k in diller)
    {
        Console.WriteLine(k);
    }
}

//CopyTo : arraylist'ten diziye eleman kopyalamak için kullanılır.
// dizi_adı.CopyTO(hedef dizi);
// dizi_adı.CopyTo(hedef dizi,indis);
// dizi_adı.CopyTo(kaynak indis,hedef dizi,hedef indis, adet);

static void arraylist9()
{
    ArrayList diller= new ArrayList();
    diller.Add("C#");
    diller.Add("Pyhton");
    diller.Add("Java");
    diller.Add("Asp");
    Array diller2 = Array.CreateInstance(typeof(string), 6);
    diller2.SetValue("Basic", 0);
    diller2.SetValue("Delphi", 1);
    diller2.SetValue("Visual Basic", 2);
    // diller.CopyTo(diller2);
    //diller.CopyTo(diller2, 2);
    //diller.CopyTo(1, diller2, 2, 2);
    diller.CopyTo(0, diller2, 3, 3);
    foreach (object k in diller2)
    {
        Console.WriteLine(k);
    }
}

static void arraylist11()
{
    /*TOArray: arraylist içerisindeki elemanları istenilen veri tipine dönüştürüğ diziye aktarmak için */
    ArrayList isimler = new ArrayList();
    isimler.Add("Hasan");
    isimler.Add("Beyza");
    isimler.Add("Ahmet");
    //isimler.Add(123456);
    //isimler.Add(true);
    string[] yeni_isimler = (string[]) isimler.ToArray(typeof(string));
    foreach (string a in yeni_isimler)
    {
        Console.WriteLine(a);  
    }

}

/* 1-100 Arasında üretilen 10 adet rastgele sayıyı A ismini bir arrayliste kaydeddip bu sayıları büyükten küçüğe ve küçükten büyüğe yazdıran c# Kodu*/

static void ornek1()
{
    ArrayList A = new ArrayList();
    Random rnd=new Random();
    for(int i = 0; i < 10; i++)
    {
        A.Add(rnd.Next(1,101));
    }
    A.Sort();
    Console.WriteLine("Küçükten Büyüğe Sıralama");
    foreach(int k in A)
    {
        Console.WriteLine(k);  
    }
    A.Reverse();
    Console.WriteLine("Büyükten Küçüğe Sıralama");
    foreach(int k in A)
    {
        Console.WriteLine(k);
    }
}

/*0 - 100 aralığında rastgele 50 sayı üretilsin, üretilmeyen diğer sayıları ekrana yazdıran c# kodu */

static void ornek2()
{//dizi veri yapısı kullanarak çözüm

    Random rnd = new Random();
    bool[] kontrol = new bool[101];
    int adet = 0;
    for(int i = 0; i < 50; i++)
    {
        kontrol[rnd.Next(0, 101)] = true;
    }
    for(int i=0;i<101;i++)
    {
        if (kontrol[i]==false)
        {
            Console.WriteLine("{0}--> -----", i);
                adet++;
        }
        else
        {
            Console.WriteLine("{0}--> üretildi", i);
        }
    }
    Console.WriteLine("Üretilmeyen sayıların adedi " + adet);
}
