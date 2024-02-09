// See https://aka.ms/new-console-template for more information
using _01_Intro.Business;
using _01_Intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "Krediler";
int term = 12;
double amount = 1000000;

//variables --> camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Button-->Hoşgeldin Musa");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}

string[] loans = { "Kredi1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//db den gelecek
                                                                                     //string[] loans2 = new string[6];
                                                                                     //loans2[0] = "Kredi 1";

//start    condition       increment 
for (int i = 0; i < loans.Length; i++)
{
    Console.Write(loans[i] + "\n");
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");