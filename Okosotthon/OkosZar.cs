using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Okosotthon
{
    public class OkosZar: OkosEszkoz
    {
        private bool zartE;
        private string pinKod;


        public OkosZar(string azonosito, string nev, string pinKod)
        : base(azonosito, nev)
        {
            ZartE = true;
            this.pinKod = pinKod;
        }
        public bool ZartE { get => zartE; private set => zartE = value; }

        public override void ParancsVegrehajtasa(string parancs)
        {
            string[] parancsresz = parancs.Split(':');

            if (parancsresz[0] == "ZARAS")
            {
                ZartE = true;
            }
            else if (parancsresz[0] == "NYITAS" && parancsresz[1] == pinKod) {
                ZartE = false;
            }
        }


        public override string AllapotJelentes()
        {
            return $"Zár állapota: {(ZartE ? "zárva" : "nyitva")}";
        }

        protected override bool OnTesztFuttatasa()
        {
            return true;
        }

        public override void GyariBeallitasokVisszaallitasa()
        {
            base.GyariBeallitasokVisszaallitasa();
            pinKod = "0000";
            ZartE = true;
        }
    }
}
