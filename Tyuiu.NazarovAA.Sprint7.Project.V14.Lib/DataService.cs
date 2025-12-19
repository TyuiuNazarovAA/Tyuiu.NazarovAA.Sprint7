namespace Tyuiu.NazarovAA.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public List<(string, int)> GetStationNamesAndFromCount(List<CityRoute> routes)
        {
            List<(string, int)> stationNamesAndFromCount = routes
                .Select(r => r.FromStation)
                .Distinct()
                .Select(i => (i, routes
                    .Count(r => r.FromStation == i)))
                .OrderByDescending(r => r.Item2)
                .ToList();

            return stationNamesAndFromCount;
        }

        public List<(string, int)> GetStationNamesAndToCount(List<CityRoute> routes)
        {
            List<(string, int)> stationNamesAndFromCount = routes
                .Select(r => r.ToStation)
                .Distinct()
                .Select(i => (i, routes
                    .Count(r => r.ToStation == i)))
                .OrderByDescending(r => r.Item2)
                .ToList();

            return stationNamesAndFromCount;
        }

        public List<CityRoute> GetSortedCityRoutes(List<CityRoute> routes, string fromStation, string toStation, string sortingCondition)
        {
            List<CityRoute> sortedCityRoutes;

            switch (sortingCondition)
            {
                case "Нет":
                    sortedCityRoutes = routes
                        .Where(r => r.FromStation == fromStation &&
                            r.ToStation == toStation)
                        .ToList();
                    break;
                case "Быстрее":
                    sortedCityRoutes = routes
                        .Where(r => r.FromStation == fromStation &&
                            r.ToStation == toStation)
                        .OrderBy(r => r.Minutes)
                        .ToList();
                    break;
                case "Медленнее":
                    sortedCityRoutes = routes
                        .Where(r => r.FromStation == fromStation &&
                            r.ToStation == toStation)
                        .OrderByDescending(r => r.Minutes)
                        .ToList();
                    break;
                default:
                    return null;
            }

            return sortedCityRoutes;
        }
    }
}
