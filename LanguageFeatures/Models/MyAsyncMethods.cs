namespace LanguageFeatures.Models;

public class MyAsyncMethods{
    public static Task<long?> GetPageLength(){
        HttpClient client = new();
        var httpTask = client.GetAsync("http://apress.com");

        return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => {
            return antecedent.Result.Content.Headers.ContentLength;
        });
    }
}