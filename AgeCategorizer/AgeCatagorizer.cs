namespace AgeCategorizer_project
{
    public class AgeCatagorizer
    {
         public string DetermineAgeCategory(int age)
    {
        if (age >= 1 && age <= 14)
        {
            return "Children";
        }
        else if (age >= 15 && age <= 24)
        {
            return "Youth";
        }
        else if (age >= 25 && age <= 64)
        {
            return "Adults";
        }
        else if (age >= 65)
        {
            return "Seniors";
        }
        else
        {
            throw new AgeCategoryException("Invalid Age");
        }
    }
    }
}