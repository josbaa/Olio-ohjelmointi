using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PetInsurance
{
    public string Species { get; private set; }
    private string Name;
    public bool IsNeutered { get; private set; }
    private double Premium;

    public PetInsurance(string species, string name, bool isNeutered, double premium)
    {
        this.Species = species;
        this.Name = name;
        this.IsNeutered = isNeutered;
        this.Premium = premium;
    }

    public string GetNeuteringStatus()
    {
        if (IsNeutered)
        {
            return "neutered";
        }
        else
        {
            return "not neutered";
        }
    }

    public override string ToString()
    {
        return $"{this.Species}: {this.Name}, {this.GetNeuteringStatus()}, insurance premium {this.Premium} e";
    }
}
