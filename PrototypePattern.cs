using System;
using System.Collections.Generic;
using System.Text;
 
namespace PrototypePattern
{
    
    public interface IMeds
    {
        
        IMeds Clone();
    }
    
    public class PermanentMeds : IMeds
    {
        public string Name { get; set; }
        public string DrugClassification { get; set; }
        public int NumberOfTablets { get; set; }
 
        
        public IMeds Clone()
        {  
            return this.MemberwiseClone() as IMeds;  
        }
    }
 
    public class TemporaryMeds : IMeds
    {
        public string Name { get; set; }
        public string DrugClassification { get; set; }
        public int NumberOfTablets { get; set; }
 
        
        public IMeds Clone()
        { 
            return this.MemberwiseClone() as IMeds;
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            PermanentMeds permanentMeds = new PermanentMeds();
            permanentMeds.Name = "Aspirin";
            permanentMeds.DrugClassification = "NSAID";
            permanentMeds.NumberOfTablets = 20;
 
            PermanentMeds permanentMedsClone = (PermanentMeds)permanentMeds.Clone();
            permanentMedsClone.Name = "Pancreatin";
            permanentMedsClone.DrugClassification = "Pancreatic/Digestive Enzymes";
 
            Console.WriteLine("Permanent Meds Details");
            Console.WriteLine("Name: {0}; DrugClassification: {1}; NumberOfTablets: {2}", 
            permanentMeds.Name, permanentMeds.DrugClassification, permanentMeds.NumberOfTablets);
 
            Console.WriteLine("Cloned Permanent Meds Details");
            Console.WriteLine("Name: {0}; DrugClassification: {1}; NumberOfTablets: {2}", 
            permanentMedsClone.Name, permanentMedsClone.DrugClassification, permanentMedsClone.NumberOfTablets);
 
            Console.ReadLine();
        }
    }
}