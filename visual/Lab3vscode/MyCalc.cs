using System;
namespace Lab3vscode
{
    public class MyCalc
    {
        public static double Add(double a, double b){
            return a + b;
        }
        public static double Substruct(double a, double b){
            return a - b;
        }
        public static double Multiply(double a, double b){
            return a * b;
        }
        public static double Divide(double a, double b){
            if(b == 0){
                Console.WriteLine("cannot Divide 0");
                return 0;
            }
            return a / b;
        }
    }
}