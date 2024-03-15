using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class BMRCalculator
    {
        private double height = 0; // any unit m.
        private double weight = 0; // any unit kg.
        private double age = 0;
        private Gender gender;
        private WeeklyActivity activeLevel;
        private double maintainWeightBMRs = 0;
        private double activityLevelFactor = 0.0;
        private double bmrValue = 0.0;
        private double looseHalfKg = 0.0;
        private double looseOneKg = 0.0;
        private double gainHalfKg = 0.0;
        private double gainOneKg = 0.0;

        public BMRCalculator()
        {
            gender = Gender.Female;
            activeLevel = WeeklyActivity.Sedentary;
        }
        // Getters and Setter
        #region
        public Gender GetGender()
        {
            return gender;
        }
        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        public WeeklyActivity GetWeeklyActivity()
        {
            return activeLevel;
        }

        public void SetWeeklyActivity(WeeklyActivity activeLevel)
        {
            this.activeLevel = activeLevel;
        }

        public double GetHeight() { return height; }
        public void SetHeight(double height) { this.height = height; }
        public double GetWeight() { return weight; }
        public void SetWeight(double weight) {  this.weight = weight; }

        public double GetAge() { return age; }
        public void SetAge(double age) {  this.age = age; }

        public double GetloosehalfKg() { return looseHalfKg; }
        public void SetloosehalfKg(double looseHalfKg) { this.looseHalfKg = looseHalfKg; }

        public double GetlooseoneKg() { return looseOneKg; }
        public void SetlooseoneKg(double looseOneKg) { this.looseOneKg = looseOneKg; }

        public double GetgainhalfKg() { return gainHalfKg; }
        public void SetgainhalfKg(double gainHalfKg) { this.gainHalfKg = gainHalfKg; }

        public double GetgainoneKg() { return gainOneKg; }
        public void SetgainoneKg(double gainOneKg) { this.gainOneKg = gainOneKg; }
        #endregion
        public double calculateBMR()
        {      
            if (gender == Gender.Female)
            {
                bmrValue = ((10 * (weight)) + (6.25 * height) - (5 * age)) - 161;
            }
            else
            {
                bmrValue = ((10 * (weight)) + (6.25 * height) - (5 * age)) + 5;
            }         
            return Math.Round(bmrValue,1);
        }
        public double activityLevel()
        {         
            if(activeLevel == WeeklyActivity.Sedentary)
            {
                activityLevelFactor = 1.2;
            }
            else if (activeLevel == WeeklyActivity.Light)
            {
                activityLevelFactor = 1.375;
            }
            else if (activeLevel == WeeklyActivity.Moderate)
            {
                activityLevelFactor = 1.550;
            }
            else if (activeLevel == WeeklyActivity.VeryActive)
            {
                activityLevelFactor = 1.725;
            }
            else if (activeLevel == WeeklyActivity.ExtraActive)
            {
                activityLevelFactor = 1.9;
            }

            maintainWeightBMRs = Math.Round((bmrValue * activityLevelFactor),1);

            SetloosehalfKg(Math.Round((maintainWeightBMRs -500),1));
            SetlooseoneKg(Math.Round((maintainWeightBMRs - 1000),1));
            SetgainhalfKg (Math.Round((maintainWeightBMRs + 500),1));
            SetgainoneKg(Math.Round((maintainWeightBMRs + 1000),1));

            return maintainWeightBMRs;
        }
    }
}
