namespace Emne3Oppgaver.Oppgave328A;

public class Water
{
    public double Amount { get; set; }
    public double Temperature { get; set; }
    public WaterState State { get; set; }
    public double ProportionFirstState { get; set; }

    public Water(double amount, double temperature,  double proportionFirstState = -1)
    {
        if (temperature is 0 or 100 && proportionFirstState < 0)
        {
            throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        }
        Amount = amount;
        Temperature = temperature;
        State = temperature < 0 ? WaterState.Ice 
            : temperature == 0 ? WaterState.IceAndFluid
            : temperature < 100 ? WaterState.Fluid
            : temperature == 100 ? WaterState.FluidAndGas
            : WaterState.Gas;
        ProportionFirstState = Temperature is 0 or 100 ? proportionFirstState : 0;
        
        // if (Temperature <= 0)
        // {
        //     State = WaterState.Ice;
        // }
        // else if (Temperature == 0)
        // {
        //     State = WaterState.IceAndFluid;
        // }
        // else if (Temperature is > 0 or < 100)
        // {
        //     State = WaterState.Fluid;
        // }
        // else if (Temperature == 100)
        // {
        //     State = WaterState.FluidAndGas;
        // }
        // else
        // {
        //     State = WaterState.Gas;
        // }
        
    }

    public Water(double amount, double temperature) : this(amount, temperature, -1) { }

    public void AddEnergy(int i)
    {
        double calories = i;
        if (Temperature < 0 )
        {
            double caloriesNeeded = (Temperature * Amount) * -1;
            if (caloriesNeeded <= calories)
            {
                Temperature = 0;
            }
            else {Temperature = Temperature + calories / Amount;}
                calories = calories - caloriesNeeded;
            // break;
        }
        if (Temperature is >= 0 and < 100)
        {
            if (State == WaterState.Ice)
            {
                var caloriesNeededToMeltIce = Amount * 80;
                var totalIceMelt = (calories / caloriesNeededToMeltIce) * Amount;
                if (totalIceMelt >= Amount)
                {
                    State = WaterState.Fluid;
                }
                else
                {
                    State = WaterState.IceAndFluid;
                    var iceLeft = Amount - totalIceMelt;
                    ProportionFirstState = iceLeft * 100 / Amount / 100;
                }
                calories = calories - caloriesNeededToMeltIce;
            }
            if (State == WaterState.Fluid)
            {
                var temp = Temperature;
                Temperature = Temperature + (calories / Amount);
                if (Temperature > 100)
                {
                    Temperature = 100;
                }
                calories = calories - (100 - temp) * Amount;
            }
        }

        if (Temperature >= 100)
        {
            if (State == WaterState.Fluid)
            {
                var caloriesNeededToConvertWaterToGas = Amount * 600;
                var totalFluidConvertedToGas = (calories / caloriesNeededToConvertWaterToGas) * Amount;
                if (totalFluidConvertedToGas >= Amount)
                {
                    calories = calories - caloriesNeededToConvertWaterToGas;
                    State = WaterState.Gas;
                    Temperature = Temperature + calories / Amount;
                }
                else
                {
                    State = WaterState.FluidAndGas;
                    var fluidLeft = Amount - totalFluidConvertedToGas;
                    ProportionFirstState = fluidLeft * 100 / Amount / 100;
                }
            }

            if (State == WaterState.FluidAndGas)
            {
                    var temp = Temperature;
                    Temperature = Temperature + (calories / Amount);
                    if (Temperature > 100)
                    {
                        Temperature = 100;
                    }
                    calories = calories - (100 - temp) * Amount;
                
            }
        }
    }
}