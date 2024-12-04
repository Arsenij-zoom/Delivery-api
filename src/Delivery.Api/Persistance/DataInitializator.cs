using Delivery.Api.Entities;

namespace Delivery.Api.Persistance;

public class DataInitializator
{
    private readonly DataContext _dataContext;

    public DataInitializator(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public void InitTables()
    {
        if (_dataContext.Countries.Any())
        {
            return;
        }

        List<City> cities = new()
        {
            new City()
            {
                Name = "Almaty"
            },
            new City()
            {
                Name = "Astana"
            }
        };

        Country country = new Country()
        {
            Name = "Kazakhstan",
            Cities = cities
        };

        _dataContext.Countries.Add(country);
        _dataContext.SaveChanges();
    }
}
