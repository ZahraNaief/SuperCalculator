using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class BMICalculator
    {
        private double height = 0; // any unit m, in
        private double weight = 0; // any unit kg, lbs
        private String name = string.Empty;
        private UnitTypes unit;
        //methods
        //default constructor does not contain parameters     
        public BMICalculator() 
        {
            unit = UnitTypes.Metric;
        }
        #region Getters and Setters
        public UnitTypes GetUnit()
        {
            return unit;
        }
        public void SetUnit(UnitTypes unit)
        {
            this.unit = unit;
        }
        public String GetName() 
        {
            return name;
        }
        public void SetName(String name)
        {
            if (!string.IsNullOrEmpty(name))  //validate name is not null
                this.name = name;
         
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {         
            {
                this.height = height;
            }    
        }
        public double GetWeight() 
        {
              return weight;
        }
        public void SetWeight(double weight)
        {
            {
                this.weight = weight;
            }          
        }
        #endregion
        public double calculateBMI() 
        { 
            double bmiValue = 0.0;
            double factor = 1.0;

            if(unit == UnitTypes.USCustomaryUnits)
            {
                factor = 703;
            }

            bmiValue = factor * ( (weight) / Math.Pow(height,2));

            return bmiValue; 
        }
        public String LowAndHighWeigt()
        {
            double lowWeight = 0;
            double highWeight = 0;
            double factor = 1.0;
            if (unit == UnitTypes.USCustomaryUnits)
            {
                factor = 703;
            }
            lowWeight = ((Math.Pow(height, 2))/(factor * 18.50));
            highWeight = ((Math.Pow(height, 2))/(factor*24.9));
            string formattedString = $"Low Weight: {lowWeight :F2}, High Weight: {highWeight :F2}";
            return formattedString;
        }
        public String FindWeightCategory(double bmi) 
        {
            String showCategory = string.Empty;

            if(bmi < 18.5)
            {
                showCategory = "You are Underweight";
            }
            else if(bmi <= 24.9)
            {
                showCategory = "Your weight is normal";
            }
            else if (bmi <= 29.9)
            {
                showCategory = "Overweight (pre-Obesity)";
            }
            else if (bmi <= 34.9)
            {
                showCategory = "Overweight (Obesity class - 1)";
            }
            else if (bmi <= 39.9)
            {
                showCategory = "Overweight (Obesity class - 2)";
            }
            else //(bmi > 40)
            {
                showCategory = "Overweight (Obesity class - 3)";
            }
            return showCategory;
        }      
    }
}
