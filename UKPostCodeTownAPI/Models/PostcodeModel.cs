namespace UKPostCodeTownAPI.Models
{
    public class PostcodeModel
    {
        public string Postcode { get; set; }

        public string Eastings { get; set; }

        public string Northings { get; set; }

        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public string Town { get; set; }

        public string Region  { get; set; }

        public string UkRegion { get; set; }

        public string Country { get; set; }

        public string CountryString { get; set; }
    }
}