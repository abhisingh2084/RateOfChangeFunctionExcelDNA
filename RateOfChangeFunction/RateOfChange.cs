using System;
using ExcelDna.Integration;


public class RateOfChangeFunction
{
    [ExcelFunction(Name = "func.RateOfChange", Description = "Rate of change")]
    public static double RateOfChange(double startValue, double endValue)
    {
         
        {
            return (endValue - startValue) / startValue;
        }
       
    }
}
