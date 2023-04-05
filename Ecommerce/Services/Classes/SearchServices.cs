using DbEcommerceApp.Data.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace UserEcommerceApp.Services.Classes;

public static class SearchServices
{
    public static ObservableCollection<BasketProduct> SearchInBasket(string searchText, ObservableCollection<BasketProduct> searchResults, ObservableCollection<BasketProduct> basketProducts)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            searchResults = new(basketProducts);
            return searchResults;
        }

        // Search elements by searchTextBox
        var results = basketProducts.Where(i => i.Product.Name == searchText);

        // Update
        searchResults.Clear();
        foreach (var result in results)
        {
            searchResults.Add(result);
        }
        return searchResults;
    }

    public static ObservableCollection<OrderProduct> SearchInOrders(string searchText, ObservableCollection<OrderProduct> searchResults, ObservableCollection<OrderProduct> basketProducts)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            searchResults = new(basketProducts);
            return searchResults;
        }

        // Search elements by searchTextBox
        var results = basketProducts.Where(i => i.Product!.Name == searchText);

        // Update
        searchResults.Clear();
        foreach (var result in results)
        {
            searchResults.Add(result);
        }
        return searchResults;
    }
}