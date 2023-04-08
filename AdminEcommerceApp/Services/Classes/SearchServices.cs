using DbEcommerceApp.Data.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace AdminEcommerceApp.Services.Classes;

public static class SearchServices
{
    public static ObservableCollection<OrderProduct> SearchInOrders(string searchText, ObservableCollection<OrderProduct> searchResults, ObservableCollection<OrderProduct> basketProducts)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            searchResults = new(basketProducts);
            return searchResults;
        }

        var results = basketProducts.Where(i => i.Product!.Name == searchText);

        searchResults.Clear();
        foreach (var result in results)
        {
            searchResults.Add(result);
        }
        return searchResults;
    }

    public static ObservableCollection<Product> SearchInHomeView(string searchText, ObservableCollection<Product> searchResults, ObservableCollection<Product> products)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            searchResults = new(products);
            return searchResults;
        }

        var results = products.Where(i => i.Name == searchText);

        searchResults.Clear();
        foreach (var result in results)
        {
            searchResults.Add(result);
        }
        return searchResults;
    }
}