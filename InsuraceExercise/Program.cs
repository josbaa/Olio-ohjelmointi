using System;

public class Ohjelma
{
    public static void Main(string[] args)
    {
        VakuutusManageri vm = new VakuutusManageri();
        vm.LisaaVakuutus("koira", "Rolle", false);
        vm.LisaaVakuutus("koira", "Tessu", true);
        vm.LisaaVakuutus("kissa", "Monni", true);
        vm.LisaaVakuutus("koira", "Pluto", false);
        vm.LisaaVakuutus("lintu", "Tipi", false);
        vm.TulostaVakuutukset();
        Console.WriteLine("---");
        vm.EtsiVakuutukset("koira", false);
    }
}
