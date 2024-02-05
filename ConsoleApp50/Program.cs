using ConsoleApp50;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        Tanks tank1 = new Tanks() { Name = "об.777", Age = "17", National = "USSR" };
        Tanks tank2 = new Tanks() { Name = "Maus", National = "Germane", Age = "45" };
        
        Random random = new Random();
        int healtc1 = random.Next(50, 100);
        int healtc2 = random.Next(50, 100);
        int damage1 = random.Next(20, 40);
         int damage2 = random.Next(20, 40);
        Console.WriteLine("Напишите в чат 'танк 1 / танк 2' , для показания их характеристик ");
        string  info = Console.ReadLine();
        if (info == null)
        {
            return;
        }
        if (info == "танк 1")
        {
            Console.WriteLine($"Параметры первого танка: \n Название - {tank1.Name}\n Страна - {tank1.National}\n Кол-во лет - {tank1.Age} \n  Урон - {damage1} " +
                $"\n Защита - {healtc1}");
            
        }
        else if (info =="танк 2")
        {
            Console.WriteLine($"Параметры второго танка: \n Название - {tank2.Name} \n Страна - {tank2.National}\n Кол-во лет - {tank2.Age}" +
              $"\n Урон - {damage2} \n Защита - {healtc2}"  ) ;
            
        }
       
        Console.ReadLine();
        Console.WriteLine("Чтобы начать битву напишите 'Battle' ");

        string fiht = Console.ReadLine();
        if (fiht == "Battle")
        {
            War();
        }
    }
    static void War()
    {
        
    }




}








