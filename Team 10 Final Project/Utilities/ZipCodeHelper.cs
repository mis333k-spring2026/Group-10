using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Utilities
{
    public static class ZipCodeHelper
    {
        public static (string City, string State)? GetCityStateFromZip(string zipCode)
        {
            return zipCode switch
            {
                "78705" => ("Austin", "TX"),
                "75205" => ("Dallas", "TX"),
                "77005" => ("Houston", "TX"),
                "10001" => ("New York", "NY"),
                _ => null
            };
        }
    }
}