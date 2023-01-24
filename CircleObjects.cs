using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {

        public double radius { get; set; }

        public Circle(double _radius) { radius = _radius; }

        //methods 

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;

        }
        public string CalculateFormattedCircumference()
        {
            string formattedCicumfrence = Math.Round(CalculateCircumference(), 2).ToString();
            return formattedCicumfrence;

        }

        public double CalculateArea()
        {
            double area = radius * radius * Math.PI;
            return area;

        }
        public string CalculateFormattedArea()
        {
            string formattedArea = Math.Round(CalculateArea(), 2).ToString();  
            Math.Round()
            return formattedArea;
        }
        private string FormatNumber(double x)
        {
            string formattedArea = Math.Round (x, 2).ToString();//the 2 is for the decimal places 
            return formattedArea;
        }

        //public double CalculateArea()
        //        {

        //        }

    }
}

//    public class Employee
//    {
//        //Properties 
//        public string Name { get; set; }
//        public decimal Salary { get; set; }
//        public string Department { get; set; }

//        //now that properties are set up -- need to set up constructor--see below 

//        public Employee(string _name, decimal _salary, string _department)//salary will need an "M" because it is a decimal 
//        {
//            Name = _name;
//            Salary = _salary;
//            Department = _department;

//        }
//        public Employee() //This is both overloaded and default (in case user doesn't provide values
//        {
//            Name = "Justin";
//            Salary = 5;
//            Department = "Head of the Back Alley";
//        }
//        // methods 
//        public string GetDetails()
//        {
//            return $"{Name}  Department {Department} Salary ${Salary}";
//        }

//    }
//}


////methods
////public decimal GetInterestRate()
////{
////    return InterestRate;
////}