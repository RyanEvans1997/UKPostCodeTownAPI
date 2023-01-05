using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UKPostCodeTownAPI.Models;

namespace UKPostCodeTownAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostcodeController : ControllerBase
    {


        [HttpGet(Name = "GetPostcode")]
        public List<PostcodeModel> Get()
        {       
            return PopulateData();           
        }

        [NonAction]
        public List<PostcodeModel> PopulateData()
        {
            List<PostcodeModel> posts = new List<PostcodeModel>();
            using (var reader = new StreamReader(@"C:\Users\r.evans\Source\Repos\UKPostCodeTownAPI\UKPostCodeTownAPI\postcodedata.csv"))
            {
                while(!reader.EndOfStream)
                {
                    PostcodeModel postcodeEntry = new PostcodeModel();

                    var line = reader.ReadLine();
                    var values = line.Split(",");

                    postcodeEntry.Postcode = values[0];
                    postcodeEntry.Eastings = values[1];
                    postcodeEntry.Northings = values[2];
                    postcodeEntry.Latitude = values[3];
                    postcodeEntry.Longitude = values[4];
                    postcodeEntry.Town = values[5];
                    postcodeEntry.Region = values[6];
                    postcodeEntry.UkRegion = values[7];
                    postcodeEntry.Country = values[8];
                    postcodeEntry.CountryString = values[9];

                    posts.Add(postcodeEntry);

                }
            }
            return posts;
        }
    }
}
