using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine("Sayıların Yer Değiştirmeden Önceki Değerleri a= " + a + " b= " + b);
        a = a * b;       
        b = a / b;
        a = a / b;    
        Console.Write("Sayıların Yer Değiştirdikten Sonraki Değerleri  a= " + a + " b= " + b);
        Console.ReadLine();
    }
}
