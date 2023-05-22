using AgeCategorizer_project ;
namespace AgeCategorizerTest{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CategoryTest()
        {
            AgeCatagorizer ageCatagorizer = new AgeCatagorizer();
            int age = 5;
            string expected = "Children";
            string output = ageCatagorizer.DetermineAgeCategory(age);
            Assert.AreEqual(expected, output);
        }
    }
}