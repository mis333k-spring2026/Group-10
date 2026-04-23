using System.Text.Json;

namespace Team10FinalProject.Utilities
{
    public static class ZipLookup
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly Dictionary<string, (string City, string State)> _cache = new();

        public static async Task<(string City, string State)> LookupAsync(string zip)
        {
            if (_cache.ContainsKey(zip)) return _cache[zip];

            try
            {
                var response = await _httpClient.GetAsync($"https://api.zippopotam.us/us/{zip}");
                if (!response.IsSuccessStatusCode) return ("Unknown", "XX");

                var json = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(json);
                var place = doc.RootElement.GetProperty("places")[0];

                var result = (
                    City: place.GetProperty("place name").GetString(),
                    State: place.GetProperty("state abbreviation").GetString()
                );

                _cache[zip] = result;
                await Task.Delay(100);
                return result;
            }
            catch
            {
                return ("Unknown", "XX");
            }
        }
    }
}