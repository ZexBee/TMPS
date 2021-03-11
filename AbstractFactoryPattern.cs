public interface IFactory
{
  void Demage(int dmg);
}

{
    interface IEnemyNCPFactory
     {
      IWeapon GetWeapon();
      IArmor GetArmor();
     }
   
   
   class Mage : IEnemyNCPFactory
    {
        public IWeapon GetWeapon()
        {
            return new Wand();
        }
    
 
        public IArmor GetArmor()
        {
            return new Cloak();
        }
    }
 
    class Warrior : IEnemyNCPFactory
    {
        public IWeapon GetWeapon()
        {
            return new Sword();
        }
 
        public IArmor GetArmor()
        {
            return new BodyArmor();
        }
    }
    
    
    interface IWeapon
    {
        string Item();
    }

    interface IArmor
    {
        string Item();
    }
    
    
    class Sword : IWeapon
    {
        public string Item()
        {
            return "Adamanite Sword";
        }
    }
 
    class Wand : IWeapon
    {
         public string Item()
        {
            return "Magic Fire Wand";
        }
    }
 
 
    class BodyArmor : IArmor
    {
      public string Item()
        {
             return "Dragon Body Armor";
        }
    }
 
    class Cloak : IArmor
    {
    public string Item()
        {
            return "Magic Cloak of Fire Resistance";
        }
    }


 class Client
    {
        IEnemyNPCFactory factory=null;
 
        public void SpawnEnemy(string enemy)
        {
            if (enemy == "Warrior")
            {
                factory = new Warrior();
                Console.WriteLine("New Warior equipment:");
                Console.WriteLine(factory.GetWeapon().Item());
                Console.WriteLine(factory.GetArmor().Item());
                Console.WriteLine(&quot;_____________________&quot;);
            }
            else if (enemy == "Mage")
            {
                factory = new Mage();
                Console.WriteLine("New Mage equipment: ");
                Console.WriteLine(factory.GetWeapon().Item());
                Console.WriteLine(factory.GetArmor().Item());
                Console.WriteLine("_____________________");
            }
            else
            {
                Console.WriteLine("Wrong type");
            }
        }
        
 
        static void Main(string[] args)
        {
        Client client = new Client();
        client.SpawnEnemy("Mage");
        client.SpawnEnemy("Warrior");
        Console.Read();
        }
    }
}


