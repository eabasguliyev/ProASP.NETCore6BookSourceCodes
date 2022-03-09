namespace LanguageFeatures.Models;

public static class MyExtensionMethods{
    public static decimal TotalPrices(this IEnumerable<Product?> products){
        decimal total = 0;

        if(products != null){
            foreach (Product? product in products)
            {
                total += product?.Price ?? 0;
            }
        }
        
        return total;
    }
}