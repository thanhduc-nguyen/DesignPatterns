namespace Adapter.ObjectAdapterImplementation
{
    public class StockModel
    {
        public string Company { get; set; }
        public decimal PriceInUsd { get; set; }
    }

    /// <summary>
    /// Service (adaptee).
    /// </summary>
    public class StockProvider
    {
        public List<StockModel> FetchData()
        {
            return new List<StockModel>
            {
                new StockModel { Company = "Apple", PriceInUsd = 180M },
                new StockModel { Company = "Amazon", PriceInUsd = 175.25M },
                new StockModel { Company = "Microsoft", PriceInUsd = 200M },
            };
        }
    }

    public class VietnameseStockModel
    {
        public string Company { get; set; }
        public decimal PriceInVnd { get; set; }
    }

    /// <summary>
    /// Client interface.
    /// </summary>
    public interface IStockAdapter
    {
        IEnumerable<VietnameseStockModel> GetData();
    }

    /// <summary>
    /// Adapter.
    /// </summary>
    public class VietnameseStockAdapter : IStockAdapter
    {
        public StockProvider StockProvider { get; set; } = new StockProvider();

        public IEnumerable<VietnameseStockModel> GetData()
        {
            return StockProvider.FetchData().Select(x => new VietnameseStockModel
            {
                Company = x.Company,
                PriceInVnd = decimal.Multiply(x.PriceInUsd, 23000M),
            });
        }
    }
}
