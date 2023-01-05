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
            List<PostcodeModel> posts = new List<PostcodeModel>();
            posts.Add(new PostcodeModel
            {
                postcode = "CV7 7PT"
            });

            return posts;
            
        }
    }
}
