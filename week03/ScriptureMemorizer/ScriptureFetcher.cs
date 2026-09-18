using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class ScriptureFetcher
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<Scripture> FetchScriptureAsync(Reference reference)
    {
        string passageQuery = reference.GetDisplayText().Replace(" ", "+");
        string url = $"https://bible-api.com/{passageQuery}";

        try
        {
            string responseJson = await _httpClient.GetStringAsync(url);

            using (JsonDocument doc = JsonDocument.Parse(responseJson))
            {
                string text = doc.RootElement.GetProperty("text").GetString().Trim();
                return new Scripture(reference, text);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching '{reference.GetDisplayText()}': {ex.Message}");
            return null;
        }
    }
}