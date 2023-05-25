using KutyaClass;
using System.IO;
using System.Linq;

List<KutyaNevek> kutyaNevekLista = new List<KutyaNevek>();
List<KutyaFajtak> kutyaFajtakLista = new List<KutyaFajtak>();
List<Kutyak> kutyakLista = new List<Kutyak>();

StreamReader nevekReader = new StreamReader("KutyaNevek.csv");
nevekReader.ReadLine();
while (!nevekReader.EndOfStream)
{
    string[] sor = nevekReader.ReadLine().Split(";");
    KutyaNevek ujKutyaNev = new KutyaNevek(Convert.ToInt32(sor[0]), sor[1]);
    kutyaNevekLista.Add(ujKutyaNev);
}
nevekReader.Close();

StreamReader fajtakReader = new StreamReader("KutyaFajtak.csv");
fajtakReader.ReadLine();
while (!fajtakReader.EndOfStream)
{
    string[] sor = fajtakReader.ReadLine().Split(";");
    KutyaFajtak ujKutyaFajta = new KutyaFajtak(Convert.ToInt32(sor[0]), sor[1], sor[2]);
    kutyaFajtakLista.Add(ujKutyaFajta);
}
fajtakReader.Close();

StreamReader kutyakReader = new StreamReader("Kutyak.csv");
kutyakReader.ReadLine();
while (!kutyakReader.EndOfStream)
{
    string[] sor = kutyakReader.ReadLine().Split(";");
    Kutyak ujKutya = new Kutyak(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]), sor[4]);
    kutyakLista.Add(ujKutya);
}
kutyakReader.Close();

//3. Feladat
Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyaNevekLista.Count()}");

//6. Feladat
double osszeg = 0;
for (int i = 0; i < kutyakLista.Count(); i++)
    osszeg += kutyakLista[i].Eletkor;
Console.WriteLine($"6. feladat: Kutyák átlag életkora: {Math.Round(osszeg / kutyakLista.Count, 2)}");

//7. Feladat
int legidosebbIndex = 0;
string neve = "";
string fajtaja = "";
for (int i = 1; i < kutyakLista.Count(); i++)
{
    if (kutyakLista[i].Eletkor > kutyakLista[legidosebbIndex].Eletkor)
        legidosebbIndex = i;
}

for (int i = 0; i < kutyaNevekLista.Count(); i++)
{
    if (kutyakLista[legidosebbIndex].NevId == kutyaNevekLista[i].KutyaNevId)
    {
        neve = kutyaNevekLista[i].KutyaNev;
        break;
    }
}

for (int i = 0; i < kutyaFajtakLista.Count(); i++)
{
    if (kutyakLista[legidosebbIndex].Fajid == kutyaFajtakLista[i].KutyaFajId)
    {
        fajtaja = kutyaFajtakLista[i].KutyaFajNev;
        break;
    }
}

Console.WriteLine($"7. feladat: Legidosebb kutya neve és fajtája: {neve}, {fajtaja}");

//8. Feladat
Dictionary<string, int> vizsgaltFajok = new Dictionary<string, int>();
for (int i = 0; i < kutyakLista.Count(); i++)
{
    string kutyaFajtaja = "";
    for (int x = 0; x < kutyaFajtakLista.Count(); x++)
    {
        if (kutyakLista[i].Fajid == kutyaFajtakLista[x].KutyaFajId)
        {
            kutyaFajtaja = kutyaFajtakLista[x].KutyaFajNev;
            break;
        }
    }
    if (kutyakLista[i].UtsOrvosiEll == "2018.01.10")
    {
        if (vizsgaltFajok.ContainsKey(kutyaFajtaja) == false)
            vizsgaltFajok.Add(kutyaFajtaja, 1);
        else
            vizsgaltFajok[kutyaFajtaja] += 1;      
    }
}
Console.WriteLine("8. feladat: Január 10. -én vizsgált kutya fajták:");
foreach (var faj in vizsgaltFajok)
{
    Console.WriteLine($"\t {faj.Key}: {faj.Value} kutya");
}


//9. Feladat
/*
  
//nem mukodik meg

Dictionary<string, int> napiVizsgalatok = new Dictionary<string, int>();
for (int i = 0; i < kutyakLista.Count(); i++)
{
    if (napiVizsgalatok.ContainsKey(kutyakLista[i].UtsOrvosiEll) == false)
        napiVizsgalatok.Add(kutyakLista[i].UtsOrvosiEll, 1);
    else 
        napiVizsgalatok[kutyakLista[i].UtsOrvosiEll] =+ 1;
}

var legForgalmasabbNapKulcsa = napiVizsgalatok.ElementAt(0).Key;
foreach (var vizsgalat in napiVizsgalatok)
{
    if (vizsgalat.Value > napiVizsgalatok[legForgalmasabbNapKulcsa])
    {
        legForgalmasabbNapKulcsa = vizsgalat.Key;
    }
}
Console.WriteLine($"9.feladat: Legjobban leterhelt nap: {legForgalmasabbNapKulcsa}: {napiVizsgalatok[legForgalmasabbNapKulcsa]}");

*/