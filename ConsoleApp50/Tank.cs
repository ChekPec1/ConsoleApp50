namespace ConsoleApp50
{
   public abstract class Tank
    {
        protected string? Name { get; init; }
        protected string? Country { get; init; }
        public int? Health { get; set; }
        public int? Damage { get; set; }

        public virtual string Info() {
            
            return $"{Name}: страна - {Country}";
        }
    }
    public class LightTank: Tank
    { 
        public LightTank(string name, string country) {
            Name = name;
            Country = country;
        }
    }
    public class MediumTank: Tank
    { 
        public MediumTank(string name, string country) {
            Name = name;
            Country = country;
        }
    }
    public class HeavyTank : Tank
    {
        public HeavyTank(string name, string country) {
            Name = name;
            Country = country;
        }
    }
   
}
