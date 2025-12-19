using Tyuiu.NazarovAA.Sprint7.Project.V14.Lib;

namespace Tyuiu.NazarovAA.Sprint7.Project.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckRoutesFileExist()
        {
            string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint7\Databases\Routes\Routes.csv";

            Assert.IsTrue(File.Exists(path));
        }
        [TestMethod]
        public void CheckGetStationNamesAndFromCount()
        {
            DataService ds = new DataService();

            List<CityRoute> routes = new List<CityRoute>()
            {
                new CityRoute("5", "ул. Мира", "ул. Ленина", 10),
                new CityRoute("31", "ул. Мира", "ул. Холодильная", 6),
                new CityRoute("19", "ул. Мира", "ул. 50 лет ВЛКСМ", 3),
                new CityRoute("19", "ул. Салехардская", "ул. 50 лет ВЛКСМ", 9),
                new CityRoute("19", "ул. Харьковская", "ОКБ №2", 10),
            };

            List<(string, int)> result = ds.GetStationNamesAndFromCount(routes);
            List<(string, int)> wait = new List<(string, int)>()
            {
                ("ул. Мира", 3),
                ("ул. Салехардская", 1),
                ("ул. Харьковская", 1)
            };

            CollectionAssert.AreEqual(wait, result);
        }
        [TestMethod]
        public void CheckGetStationNamesAndToCount()
        {
            DataService ds = new DataService();

            List<CityRoute> routes = new List<CityRoute>()
            {
                new CityRoute("5", "ул. Мира", "ул. Ленина", 10),
                new CityRoute("31", "ул. Мира", "ул. Холодильная", 6),
                new CityRoute("19", "ул. Мира", "ул. 50 лет ВЛКСМ", 3),
                new CityRoute("19", "ул. Салехардская", "ул. 50 лет ВЛКСМ", 9),
                new CityRoute("19", "ул. Харьковская", "ОКБ №2", 10),
            };

            List<(string, int)> result = ds.GetStationNamesAndToCount(routes);
            List<(string, int)> wait = new List<(string, int)>()
            {
                ("ул. 50 лет ВЛКСМ", 2),
                ("ул. Ленина", 1),
                ("ул. Холодильная", 1),
                ("ОКБ №2", 1)
            };

            CollectionAssert.AreEqual(wait, result);
        }
        [TestMethod]
        public void CheckGetSortedCityRoutes()
        {
            DataService ds = new DataService();

            List<CityRoute> routes = new List<CityRoute>()
            {
                new CityRoute("5", "ул. Мира", "ул. Ленина", 10),
                new CityRoute("31", "ул. Мира", "ул. Холодильная", 10),
                new CityRoute("3", "ул. Мира", "ул. Холодильная", 4),
                new CityRoute("16", "ул. Мира", "ул. Холодильная", 6),
                new CityRoute("19", "ул. Мира", "ул. 50 лет ВЛКСМ", 3),
                new CityRoute("19", "ул. Салехардская", "ул. 50 лет ВЛКСМ", 9),
                new CityRoute("19", "ул. Харьковская", "ОКБ №2", 10),
            };

            List<CityRoute> result = ds.GetSortedCityRoutes(routes, "ул. Мира", "ул. Холодильная", "Быстрее");
            List<CityRoute> wait = new List<CityRoute>()
            {
                new CityRoute("3", "ул. Мира", "ул. Холодильная", 4),
                new CityRoute("16", "ул. Мира", "ул. Холодильная", 6),
                new CityRoute("31", "ул. Мира", "ул. Холодильная", 10)
            };

            CollectionAssert.AreEqual(wait, result);
        }

    }
}
