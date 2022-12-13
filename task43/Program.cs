using System;
using static System.Console;

Clear();
WriteLine("Ввидите координату B1: ");
double B1 = double.Parse(ReadLine());

WriteLine("Ввидите координату K1: ");
double K1 = double.Parse(ReadLine());

WriteLine("Ввидите координату B2: ");
double B2 = double.Parse(ReadLine());

WriteLine("Ввидите координату K2: ");
double K2 = double.Parse(ReadLine());

WriteLine(String.Join(" ", GetPoint(B1, K1, B2, K2)));

double[] GetPoint(double xB1, double xK1, double xB2, double xK2)
{
    double[] result = new double[2];
    result[0] = (xB2 - xB1) / (xK1 - xK2);
    result[1] = xK1 * result[0] + xB1;
    return result;
   
}