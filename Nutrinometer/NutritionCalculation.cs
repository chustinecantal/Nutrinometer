using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrinometer
{
    internal class NutritionCalculation
    {
        public double CalculateBMR(string sex, double weight, double height, int age)
        {
            double bmr = 0;
            if (sex.ToLower() == "Male")
            {
                bmr = 66.5 + (13.8 * weight) + (5 * height) - (6.75 * age);
            }
            else if (sex.ToLower() == "Female")
            {
                bmr = 655 + (9.6 * weight) + (1.9 * height) - (4.7 * age);
            }
            return bmr;
        }

        public double CalculateDailyCalories(int actLevel, double bmr)
        {
            double calories = 0;
            switch (actLevel)
            {
                case 1: // Sedentary
                    calories = (bmr * 1.2) / 3;
                    break;
                case 2: // Lightly Active
                    calories = (bmr * 1.375) / 3;
                    break;
                case 3: // Moderately Active
                    calories = (bmr * 1.55) / 3;
                    break;
                case 4: // Very Active
                    calories = (bmr * 1.725) / 3;
                    break;
            }
            return calories;
        }

        public string AnalyzeCalories(string username, double totalCalories, double requiredCalories)
        {
            string status = "";
            if (totalCalories > requiredCalories)
            {
                status = "Higher Than Required Calories.";
            }
            else if (totalCalories < requiredCalories)
            {
                status = "Lower Than Required Calories.";
            }
            else
            {
                status = "Met Required Calories.";
            }
            return status;
        }
    }
}
