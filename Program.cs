using System.ComponentModel.Design;

internal class Program
{
    static void Tax(out decimal tax)
    {
        tax= 1;
        Console.WriteLine("введите ваш доход");
        decimal d = Convert.ToDecimal(Console.ReadLine());
        //d доход
        Console.WriteLine("введите процент");
        decimal p = Convert.ToDecimal(Console.ReadLine());
        //p процент
        tax = d * p / 100;
    }
    private static void Main(string[] args)
    {
        decimal tax;
        Tax(out tax);
      
        if (tax >= 0)
        {
            bool b = true;
            Console.WriteLine("расчте налога завершен");
            Console.WriteLine("ваш налог составляет {0}", tax);
        }
        else
        {
            bool b = false;
            Console.WriteLine("расчет налога не удался");
        }
        
        
    }
}