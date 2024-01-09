using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakopark_inform
{
    internal class Lakopark
    {
        readonly int lakoparkid;
        string lakoparkNeve;
        int utcaSzam;
        int telekSzam;
        int[,] hazak;   //--utsza és telekérték alapján az emeletszámot adja érte

        public int Lakoparkid { get => lakoparkid; }
        public string LakoparkNeve { get => lakoparkNeve; set => lakoparkNeve = value; }
        public int UtcaSzam { get => utcaSzam; set => utcaSzam = value; }
        public int TelekSzam { get => telekSzam; set => telekSzam = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }

        public Lakopark(int lakoparkid, string lakoparkNeve, int utcaSzam, int telekSzam)
        {
            this.lakoparkid = lakoparkid;
            LakoparkNeve = lakoparkNeve;
            UtcaSzam = utcaSzam;
            TelekSzam = telekSzam;
            this.hazak = new int[utcaSzam, telekSzam];
        }

        internal void HazAdat(int utcaszam, int hazszam, int emelet)
        {
            this.hazak[utcaszam - 1, hazszam - 1]=emelet;
        }
    }
}
