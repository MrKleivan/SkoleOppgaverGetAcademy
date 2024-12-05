namespace Emne3Oppgaver.Oppgave328A;

public class Water
{
    public double Amount { get; set; }
    public double Temperature { get; set; }
    public WaterState State { get; set; }
    public double ProportionFirstState { get; set; }

    public Water(int amount, int temperature,  double proportionFirstState = -1)
    {
        if (temperature is 0 or 100 && proportionFirstState < 0)
        {
            throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        }
        Amount = amount;
        Temperature = temperature;
        ProportionFirstState = Temperature is 0 or 100 ? proportionFirstState : 0;
        
        if (Temperature <= 0)
        {
            State = WaterState.Ice;
        }
        else if (Temperature == 0)
        {
            State = WaterState.IceAndFluid;
        }
        else if (Temperature < 100)
        {
            State = WaterState.Fluid;
        }
        else if (Temperature == 100)
        {
            State = WaterState.FluidAndGas;
        }
        else
        {
            State = WaterState.Gas;
        }
        
    }

    public Water(int amount, int temperature) : this(amount, temperature, -1) { }

    public void AddEnergy(int i)
    {
        var enegyPrAmount = i / Amount;
        if (Temperature < 0 )
        {
            Temperature -= Temperature * Amount * 1 / 4;
        }
        if (Temperature is >= 0 and <= 100)
        {
            while (true)
            {
                Temperature += enegyPrAmount;
                    break;
            }
        }

        if (Temperature > 100)
        {
            Temperature += enegyPrAmount;
        }
    }
}