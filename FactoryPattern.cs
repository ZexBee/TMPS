using System;
using System.Collections.Generic;
using System.Text;
 
namespace FactoryPattern

{

    public interface IFactory
    {
    void Damage(int dmg);
    }

    public class Gnome : IFactory
    {
        int _health=120;
        public void Damage(int dmg)
        {
            _health -= dmg;
            Console.WriteLine("Gnome health:" + _health.ToString());
        }
    }
    
    public class BossGnome : IFactory
    {
        int _health = 555;
        public void Damage(int dmg)
        {
            _health -= dmg;
            Console.WriteLine("Boss Gnome health:" + _health.ToString());
        }
    }

    
    public abstract class EnemyFactory
    {
        public abstract IFactory InstantiateEnemy(int type);
    }

    
    public class InstantiateEnemyFactory : EnemyFactory
    {
        public override IFactory InstantiateEnemy(int type)
        {
            switch (type)
            {
                case 1:
                    return new Gnome();
                case 2:
                    return new BossGnome();
                default:
                    throw new ApplicationException(string.Format("Wrong number"));
            }
        }
    }

    class Program
    {
    static void Main(string[] args)
        {
           
            int type = new Random().Next(1, 1000)% 2 + 1;
            
            EnemyFactory factory = new InstantiateEnemyFactory();
            
            IFactory newEnemy= factory.InstantiateEnemy(type);
            newEnemy.Damage(12);
            
            type = new Random().Next(1, 2000)%2 + 1;
            
            IFactory newEnemy2 = factory.InstantiateEnemy(type);
            newEnemy2.Damage(47);
            
            Console.ReadLine();
    
        }
    }

}
