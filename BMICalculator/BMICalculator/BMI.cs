using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BMI
    {
        private double height, weight, bmi;

        public BMI() { }
        public BMI(double kilograms, double centimeters)
        {
            kilograms = weight;
            centimeters = height;
            double bodyMassIndex = height / (weight * weight);
            //return bodyMassIndex;

        }

        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public string BMIString(double w, double h)
        {
            double mh = h / 100;
            double bmi = w / (mh * mh);
            string bmiCat = CalcCat(bmi);
            string outPut = "Your BMI is:  " + bmi + bmiCat;
            return outPut;
        }

        public string CalcCat(double bmi)
        {
            string cat ="";
            if (bmi < 15) cat = ": Very Severely Underweight";
            if (bmi < 16) cat = ": Severely Underweight";
            if (bmi < 18.5) cat = ": Underweight";
            if (bmi < 25) cat = ": Normal (healthy weight)";
            if (bmi < 30) cat = ": Overweight";
            if (bmi < 35) cat = ": Obese Class I (Moderately Obese)";
            if (bmi < 40) cat = ": Obese Class II (Severely Obese)";
            if (bmi >= 40) cat = ": Obese Class III (Very Severely Obese)";
            return cat;
        }
    }
}
