using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace KutyaClass
{
    internal class KutyaNevek
    {
        int kutyaNevId;
        string kutyaNev;

        public KutyaNevek(int kutyaNevId, string kutyaNev)
        {
            this.kutyaNevId = kutyaNevId;
            this.kutyaNev = kutyaNev;
        }

        public int KutyaNevId { get => kutyaNevId; }
        public string KutyaNev { get => kutyaNev; }
    }

    internal class KutyaFajtak
    {
        int kutyaFajId;
        string kutyaFajNev;
        string kutyaEredetiFajNev;

        public KutyaFajtak(int kutyaFajId, string kutyaFajNev, string kutyaEredetiFajNev)
        {
            this.kutyaFajId = kutyaFajId;
            this.kutyaFajNev = kutyaFajNev;
            this.kutyaEredetiFajNev = kutyaEredetiFajNev;
        }

        public int KutyaFajId { get => kutyaFajId; }
        public string KutyaFajNev { get => kutyaFajNev; }
        public string KutyaEredetiFajNev { get => kutyaEredetiFajNev; }
    }

    internal class Kutyak
    {
        int kutyaId;
        int fajid;
        int nevId;
        int eletkor;
        string utsOrvosiEll;
        public Kutyak(int kutyaId, int fajid, int nevId, int eletkor, string utsOrvosiEll)
        {
            this.kutyaId = kutyaId;
            this.fajid = fajid;
            this.nevId = nevId;
            this.eletkor = eletkor;
            this.utsOrvosiEll = utsOrvosiEll;
        }

        public int KutyaId { get => kutyaId; }
        public int Fajid { get => fajid; }
        public int NevId { get => nevId; }
        public int Eletkor { get => eletkor; }
        public string UtsOrvosiEll { get => utsOrvosiEll; }
    }
}
