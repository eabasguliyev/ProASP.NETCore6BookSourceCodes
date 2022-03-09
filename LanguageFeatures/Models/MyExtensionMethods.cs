namespace LanguageFeatures.Models;

public static class MyExtensionMethods{
    public static decimal TotalPrices(this ShoppingCart cartParam){
        decimal total = 0;

        if(cartParam.Products != null){
            foreach (Product? product in cartParam.Products)
            {
                total += product?.Price ?? 0;
            }
        }
        
        return total;
    }
}