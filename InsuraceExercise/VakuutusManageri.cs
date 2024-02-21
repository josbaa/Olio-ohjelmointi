using System;
using System.Collections.Generic;

public class VakuutusManageri
{
    private List<Vakuutus> vakuutukset;

    public VakuutusManageri()
    {
        this.vakuutukset = new List<Vakuutus>();
    }

    public void LisaaVakuutus(string elain, string nimi, bool onLeikattu)
    {
        double maksu = HaeMaksu(elain, onLeikattu);
        Vakuutus uusiVakuutus = new Vakuutus(elain, nimi, onLeikattu, maksu);
        vakuutukset.Add(uusiVakuutus);
    }

    private double HaeMaksu(string laji, bool onLeikattu)
    {
        switch (laji)
        {
            case "koira":
                return onLeikattu ? 50 : 80;
            case "kissa":
                return onLeikattu ? 40 : 60;
            default:
                return 0;
        }
    }

    public void TulostaVakuutukset()
    {
        vakuutukset.ForEach(vakuutus => Console.WriteLine(vakuutus.ToString()));
    }

    public void EtsiVakuutukset(string laji, bool onLeikattu)
    {
        List<Vakuutus> sopivatVakuutukset = vakuutukset.FindAll(vakuutus => vakuutus.laji == laji && vakuutus.leikattu == onLeikattu);
        sopivatVakuutukset.ForEach(vakuutus => Console.WriteLine(vakuutus.ToString()));
    }
}