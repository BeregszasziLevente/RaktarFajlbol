
using RaktarFajlbol;
using System.IO;

List<Termek> termekek  =  new List<Termek>();

string[] beolvasott = File.ReadAllLines("termekek.txt");

foreach (var sor in beolvasott)
{
    string[] adatok = sor.Split(';');
    Termek peldany = new Termek();
    peldany.Nev = adatok[0];
    peldany.Egysegar = int.Parse(adatok[1]);
    peldany.RaktaronDb=int.Parse(adatok[2]);

    termekek.Add(peldany);
}

Console.WriteLine("Raktáron lévő termékek:");

int teljesErtek = 0;
int osszDarab = 0;
int osszEgysegar=0;
foreach (var sor in termekek)
{
    Console.WriteLine($"\t- {sor.Nev}: {sor.Egysegar} Ft/db ({sor.RaktaronDb}) -> Érték: {sor.Egysegar * sor.RaktaronDb} Ft");
    teljesErtek += sor.Egysegar * sor.RaktaronDb;
    osszDarab+= sor.RaktaronDb;
    osszEgysegar+= sor.Egysegar;
}

double atlag = (double)osszEgysegar / (double)termekek.LongCount();

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Raktár teljes összértéke: {teljesErtek} Ft");
Console.WriteLine($"Termékek átlagos egységára: {atlag:f0} Ft");