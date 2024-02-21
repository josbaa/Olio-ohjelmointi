using System;

public class Program
{
    public static void Main(string[] args)
    {
        InsuranceManager vm = new InsuranceManager();
        vm.AddInsurance("Dog", "Rolle", false);
        vm.AddInsurance("Dog", "Tessu", true);
        vm.AddInsurance("Dog", "Monni", true);
        vm.AddInsurance("Dog", "Pluto", false);
        vm.AddInsurance("Bird", "Tipi", false);
        vm.PrintInsurances();
        Console.WriteLine("---");
        vm.FindInsurances("Dog", false);
    }
}
