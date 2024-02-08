namespace ConsoleApp50
{
    public class Program
    {
        private static void Main()
        {
            List<Tank> tanks = new()
            {
                new HeavyTank("Об.777", "USSR"),
                new HeavyTank("Маус", "Germany"),
                new HeavyTank("ИС-7", "USSR"),
                new MediumTank("AMX-30-B", "France")
            };

            Random random = new();
            foreach (var tank in tanks)
            {
                tank.Health = random.Next(50, 100);
                tank.Damage = random.Next(20, 40);
            }

            Console.WriteLine("Привет! Это игра битва танков");

            for (var i = 0; i < tanks.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {tanks.ElementAt(i).Info()}");
            }

            Tank myTank;
            if (int.TryParse(Console.ReadLine(), out var choice))
            {
                try
                {
                    myTank = tanks.ElementAt(choice);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                return;
            }

            Console.WriteLine("Отличный выбор!");
            Console.WriteLine("Чтобы начать битву напишите 'Battle' ");

            var fight = Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException();
            if (fight != "battle") return;
            Console.WriteLine(War(myTank, tanks) ? "Ты победил!" : "Ты проиграл!");
        }

        private static bool War(Tank playerTank, List<Tank> tanks)
        {
            Random random = new();
            var opponent = tanks.ElementAt(random.Next(0, tanks.Count - 1));
            Console.WriteLine($"Твой соперник: {opponent.Info()}");
            if (random.Next(0, 1) == 1)
            {
                Console.WriteLine("Вы стреляете первым");
                while (playerTank.Health > 0)
                {
                    playerTank.Health -= opponent.Damage;
                    opponent.Health -= playerTank.Damage;
                    Console.WriteLine($"Вы обменялись выстрелами.\nУ вас осталось {playerTank.Health} здоровья.");
                    if (opponent.Health < 0)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ваш оппонент выстрелил первым");
                while (playerTank.Health > 0)
                {
                    playerTank.Health -= opponent.Damage;
                    opponent.Health -= playerTank.Damage;
                    Console.WriteLine($"Вы обменялись выстрелами.\nУ вас осталось {playerTank.Health} здоровья.");
                    if (opponent.Health < 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}







