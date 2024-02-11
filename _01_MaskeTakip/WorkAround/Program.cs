// See https://aka.ms/new-console-template for more information

using Entities.Concrete;
using System;

SelamVer("Musa");
SelamVer();
int sonuc = Topla(3, 5);

//Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] {"Ankara" , "İstanbul" , "İzmir"};
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" }; //array,class,interface,abstract ref tipleridir.

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2=sayi1;
sayi1 = 30;
Console.WriteLine(sayi2); //int,double,bool değer tipleridir.

Person person1 = new Person();
person1.FirstName = "Engin";

Person person2 = new Person();
person2.FirstName = "Murat";



foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//MyList koleksiyonu yaz. Dakika 03:09:00
List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
yeniSehirler1.Add("Adana1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}


Console.ReadLine();



static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}




static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}




static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000; // db den gelir
    int sayi = 100;
    bool GirisYapmisMi = false;

    string ad = "Musa";
    string soyad = "Ocak";
    int dogumYili = 1998;
    long tcNO = 12345678910;

    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
}





//pascal casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}