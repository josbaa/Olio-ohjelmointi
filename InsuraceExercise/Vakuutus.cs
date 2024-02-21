using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   
    public class Vakuutus
    {
        public string laji;
        private string nimi;
        public bool leikattu;
        private double maksu;

        public Vakuutus(string elain, string nimi, bool onLeikattu, double maksu)
        {
            this.laji = elain;
            this.nimi = nimi;
            this.leikattu = onLeikattu;
            this.maksu = maksu;
        }

        public string HaeLeikattuTieto()
        {
            if (leikattu)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }

        public override string ToString()
        {
            return this.laji + ": " + this.nimi + ", " + this.HaeLeikattuTieto() + ", vakuutusmaksu " + this.maksu + " e";
        }
    }

