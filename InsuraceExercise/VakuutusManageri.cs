using System;
using System.Collections.Generic;

public class InsuranceManager
{
    private List<PetInsurance> Insurance;

    public InsuranceManager()
    {
        this.Insurance = new List<PetInsurance>();
    }

    public void AddInsurance(string animal, string name, bool neutred)
    {
        double payment = ApplyPayment(animal, neutred);
        PetInsurance newInsurance = new PetInsurance(animal, name, neutred, payment);
        Insurance.Add(newInsurance);
    }

    private double ApplyPayment(string species, bool Neutred)
    {
        switch (species)
        {
            case "Dog":
                return Neutred ? 50 : 80;
            case "Cat":
                return Neutred ? 40 : 60;
            default:
                return 0;
        }
    }

    public void PrintInsurances()
    {
        Insurance.ForEach(Insurance => Console.WriteLine(Insurance.ToString()));
    }

    public void FindInsurances(string species, bool Neutred)
    {
        List<PetInsurance> suitableInsurances = Insurance.FindAll(Insurance => Insurance.Species == species && Insurance.IsNeutered == Neutred);
        suitableInsurances.ForEach(Insurance => Console.WriteLine(Insurance.ToString()));
    }
}