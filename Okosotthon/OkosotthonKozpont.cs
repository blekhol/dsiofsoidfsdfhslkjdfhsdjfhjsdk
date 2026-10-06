using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class OkosotthonKozpont
    {
        private readonly List<OkosEszkoz> eszkozok = [];

        public void EszkozHozzaadasa(OkosEszkoz eszkoz)
        {
            eszkozok.Add(eszkoz);
        }

     
        public void OsszesCsatlakoztatasa()
        {
            foreach (var item in eszkozok)
            {
                item.Csatlakozas();
            }
        }

        public int RendszerDiagnosztikaFuttatasa()
        {
            int db = 0;
            foreach (var item in eszkozok)
            {
                if (item.DiagnosztikaFuttatasa())
                {
                    db++;
                }
            }

            return db;
        }

    }
}
