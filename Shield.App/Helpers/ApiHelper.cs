using System.Net.Http.Json;
using Microsoft.Extensions.Primitives;
using Windows.Storage;

namespace Shield.App.Helpers;
public class ApiHelper
{
    private static string baseAddress = "http://127.0.0.1:5277/api";
    private static HttpClient sharedClient = new()
    {
        
        
    };
    private static string? token => (string?)ApplicationData.Current.LocalSettings.Values["apiToken"];

    public static async Task<string?> TryLogin(string name, string password)
    {
        using HttpRequestMessage request = new HttpRequestMessage();
        request.RequestUri = new Uri($"{baseAddress}/user/login");
        request.Method = HttpMethod.Post;
        request.Content = JsonContent.Create(new LoginDto() { UserName=name, Password=password });

        try
        {
            var response = await sharedClient.SendAsync(request);
            return response.Content.ToString();
        }
        catch (Exception ex)
        {
            return ex.Message + (ex.InnerException != null ? "\n" + ex.InnerException.Message : "");
        }
    }

    private class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}