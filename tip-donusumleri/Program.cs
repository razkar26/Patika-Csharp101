internal class Program
{
    private static void Main(string[] args)
    {
        // Implicit Conversion -- Bilinciz ya da kapalı dönüşüm.
        Console.WriteLine("***** Implicit Conversion *****");
        byte a = 5;
        sbyte b = 30;
        short c = 10;
        int d = a+ b + c;
        Console.WriteLine("d:"+d);
        long e = d;
        Console.WriteLine("e:"+e);
        float f = e;
        Console.WriteLine("f:"+f);

        string g = "Remzi";
        char h = 'M';
        object o = g + h + d;
        Console.WriteLine("o:"+o);
        // Explicit Conversion -- bilinçli dönüşümler
        Console.WriteLine("******* Explicit Conversion ********");

        int z = 100;
        byte t=(byte)z;
        Console.WriteLine("t:" + t);
        float w = 10.30f;
        byte v=(byte)w;
        Console.WriteLine("v:"+v);

        // ToString Metodu
        Console.WriteLine("***** ToString Metodu *****");
        int xx = 66;
        string yy=xx.ToString();
        Console.WriteLine("yy:"+yy);
        string zz = 123.30f.ToString();
        Console.WriteLine("zz:"+zz);
        // System.Convert
        Console.WriteLine("**** System.Convert *****");
        string s1 = "10", s2 = "20";
        int sayi1,sayi2,toplam;
        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);
        toplam = sayi1 + sayi2;
        Console.WriteLine("toplam:"+ toplam);

        //Parse  
        Console.WriteLine("***** Parse *****");
        ParseMethod();



    }
    public static void ParseMethod()
    {
        string metin1 = "10"; // string ifadeleri dönüştürmek için kullanılır ve her zaman string olur.
        string metin2 = "10,25";// double da . ayracını kabul etmez , ayracı ile yazılması lazım
        int rakam1;
        double double1;

        rakam1=Int32.Parse(metin1);
        double1= Double.Parse(metin2);
        Console.WriteLine("rakam1:"+rakam1);
        Console.WriteLine("double1:" + double1);

    }
}