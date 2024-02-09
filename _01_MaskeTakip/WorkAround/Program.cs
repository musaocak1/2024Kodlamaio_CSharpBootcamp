// See https://aka.ms/new-console-template for more information

using System;

SelamVer("Musa");
SelamVer();
int sonuc = Topla(3,5);

Console.ReadLine();

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5 , int sayi2 = 10)
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