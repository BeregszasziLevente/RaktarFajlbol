
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