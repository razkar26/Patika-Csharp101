internal class Program
{
    private static void Main(string[] args)
    {
        // Atama ve İşlemli Atama
        Console.WriteLine("************ Atama ve İşlemli Atama *******");
        int x = 3;
        int y = 3;
        y += 2;//y sayısını 2 artır ve degeri y sayısına ata..
        Console.WriteLine(y);
        y /= 1;//y sayısını 1 e böl ve degeri  y sayısına ata.
        Console.WriteLine(y);
        y *= 2;//y sayısını 2 ile çarp ve degeri y sayısına ata.
        Console.WriteLine(y);
        y -= 1;//y sayısını 1 cıkar ve degeri y sayısına ata.
        Console.WriteLine(y);


        Console.WriteLine("************ Mantıksal Operatörler *******");
        bool isSucces = true;
        bool isFail = false;

        if (isSucces && isFail)// true ve false  - false olur ve if blogu çalışmaz
        {
            Console.WriteLine("Perfect!");
        }
        if (isSucces || isFail)// true veya false  - true olur ve if blogu çalışır.
        {
        
            Console.WriteLine("Great!");
        }
        if (isSucces && !isFail)
        {
            Console.WriteLine("Fine!");
        }

        Console.WriteLine("************ İlişkisel Operatörler *******");
        int a = 3;
        int b = 4;
        bool deger = a < b;
        Console.WriteLine(deger);
        deger = a <= b;
        Console.WriteLine(deger);
        deger= a > b;
        Console.WriteLine(deger);
        deger=a >= b;
        Console.WriteLine(deger);
        deger = a == b;
        Console.WriteLine(deger);
        deger = a != b;
        Console.WriteLine(deger);


        Console.WriteLine("************ Matematiksel Operatörler *******");

        int sayi1 = 20;
        int sayi2 = 10;
        int sonuc;

        sonuc=sayi1 + sayi2;
        Console.WriteLine(sonuc);
        sonuc =sayi1 - sayi2;
        Console.WriteLine(sonuc);
        sonuc =sayi1 * sayi2;
        Console.WriteLine(sonuc);
        sonuc=sayi1 / sayi2;
        Console.WriteLine(sonuc);
        sayi1 = sayi1++;
        Console.WriteLine(sayi1);


        Console.WriteLine("***** Mod Alma İşlemi *****");
        // % : mod alır.  iki sayı bölümünde kalanı verir.
        int a1 = 20;
        int b1 = 3;
        int sonuc2=a1 % b1;
        Console.WriteLine(sonuc2);
    }
}