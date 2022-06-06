using System.Collections.Generic;
using Web_App_Practice_1_Refresher_5_19_2022.Models;

namespace Web_App_Practice_1_Refresher_5_19_2022.Services
{
    public interface IProductDataService 
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    } 
}
