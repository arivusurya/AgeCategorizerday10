using System.Collections.Generic;

namespace AgeCategorizer_project{
    public class Program{
        public static void Main(string[] args)
        {
            AgeCatagorizer agecatagorizer = new AgeCatagorizer();
        
        try
        {
            int personAge = 30; // Enter the person's age here
            string ageCategory = agecatagorizer.DetermineAgeCategory(personAge);
            Console.WriteLine($"Age Category: {ageCategory}");
        }
        catch (AgeCategoryException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled Exception: {ex.Message}");
        }
        }
    }
}