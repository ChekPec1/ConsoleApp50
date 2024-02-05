using ConsoleApp50;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        Tanks tank1 = new Tanks() { Name = "об.777", Age = "17", National = "USSR" };
        Tanks tank2 = new Tanks() { Name = "Maus", National = "Germane", Age = "45" };
        Tanks tank3 = new Tanks() { Name = "Ис-7", National = "USSR", Age = "39" };
        Tanks tank4 = new Tanks() { Name = "Aмx-30-B", National = "France", Age = "25" };


        Console.WriteLine("Привет! Это игра битва танков");
        Random random = new Random();
        Console.ReadLine();
        Console.WriteLine("Выбери свой танк: \n об.777, Maus, Ис-7, Амх-30-B ");
        int healtc1 = random.Next(50, 100);
        int healtc2 = random.Next(50, 100);
        int damage1 = random.Next(20, 40);
        int damage2 = random.Next(20, 40);
        int damage3 = random.Next(20, 40);
        int damage4 = random.Next(20, 40);
        int healtc3 = random.Next(50, 100);
        int healtc4 = random.Next(50, 100);//и это надо бы в лист добавить 
        string  info = Console.ReadLine();
      
      
        if (info == null)
        {
            return;
        }
        if (info == "об.777")
        {
            Console.WriteLine($"Параметры об.777: \n Название - {tank1.Name}\n Страна - {tank1.National}\n Кол-во лет - {tank1.Age} \n  Урон - {damage1} " +
                $"\n Защита - {healtc1}");
            
        }
         else if (info =="Maus")
        {
            Console.WriteLine($"Параметры Maus: \n Название - {tank2.Name} \n Страна - {tank2.National}\n Кол-во лет - {tank2.Age}" +
              $"\n Урон - {damage2} \n Защита - {healtc2}"  ) ;
            
        }
        else if(info == "Ис-7")
        {
            Console.WriteLine($"Параметры Ис-7: \n Название - {tank3.Name} \n Страна - {tank3.National}\n Кол-во лет - {tank3.Age}" +
              $"\n Урон - {damage3} \n Защита - {healtc3}");

        }
        else if(info == "Aмх-30-В")
        {
            Console.WriteLine($"Параметры Амх-30-В: \n Название - {tank4.Name} \n Страна - {tank4.National}\n Кол-во лет - {tank4.Age}" +
              $"\n Урон - {damage4} \n Защита - {healtc4}");

        }
        Console.WriteLine("Отличный выбор, выше его характеристика");
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
        Random rnd = new Random();
        string[] opponent = { "Maus", "Ис-7", "об.777", "Амх-30-В" };
      
        Console.WriteLine($"Твой соперник: {opponent}"); // кароч нужно чтобы рандомно выбирал соперника 
    }




}








