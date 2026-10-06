using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class Termosztat : OkosEszkoz
    {
        private double jelenlegiHomerseklet = 21.0;
        double celHomerseklet;

        public Termosztat(string azonosito, string nev, double celHomerseklet)
        : base(azonosito, nev)
        {
            this.CelHomerseklet = celHomerseklet;
        }

        public double JelenlegiHomerseklet { get => jelenlegiHomerseklet; private set => jelenlegiHomerseklet = value; }
        public double CelHomerseklet { get => celHomerseklet; private set => celHomerseklet = value; }

        public override void ParancsVegrehajtasa(string parancs)
        {
            if (parancs.Contains("BEALLIT_HOMERSEKLET:"))
            {
                CelHomerseklet = double.Parse(parancs.Split(':')[1]);
            }
        }

        public override string AllapotJelentes()
        {
            return $"jelenleg: {jelenlegiHomerseklet}, cél: {celHomerseklet}";
        }

        protected override bool OnTesztFuttatasa()
        {
            return CelHomerseklet > 5.0 && CelHomerseklet < 35.0;
        }

    }
}
