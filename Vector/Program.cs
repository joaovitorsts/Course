// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];
double sum = 0;
for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    sum += vect[i];
}

double avg = sum / n;
Console.WriteLine(avg);