using CustomArttribute.Utility;
using CustomAttribute.Utility;
using Microsoft.AspNetCore.Http;

namespace CustomAttribute.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        [MaxFileResolution(1)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile Image { get; set; }
    }
}
