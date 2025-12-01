using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
  public class Rectangle
  {
    private double length,breadth;

        // creating getter and setter using expression body

        public double Length
        {
            get => length;
            set => length = value;
        }
        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }
        public double Area() => length * breadth;

        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}, Area: {Area()}";
        




    }
}
