using KutyaClass;
using System.IO;
using System.Linq;

List<KutyaNevek> kutyaNevekLista = new List<KutyaNevek>();
List<KutyaFajtak> kutyaFajtakLista = new List<KutyaFajtak>();
List<Kutyak> kutyakLista = new List<Kutyak>();

StreamReader nevekReader = new StreamReader("KutyaNevek.csv");
while (!nevekReader.EndOfStream)
{
    string[] sor = nevekReader.ReadLine().Split(";");
    KutyaNevek ujKutyaNev = new KutyaNevek(Convert.ToInt32(sor[0]), sor[1]);
    kutyaNevekLista.Add(ujKutyaNev);
}
nevekReader.Close();

StreamReader fajtakReader = new StreamReader("KutyaFajtak.csv");
while (!nevekReader.EndOfStream)
{
    string[] sor = fajtakReader.ReadLine().Split(";");
    KutyaFajtak ujKutyaFajta = new KutyaFajtak(Convert.ToInt32(sor[0]), sor[1], sor[2]);
    kutyaFajtakLista.Add(ujKutyaFajta);
}
fajtakReader.Close();