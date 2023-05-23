using System.ComponentModel.DataAnnotations;

namespace AssessmentUser.Models
{
    public class LoginPage
    {
        [Key]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
