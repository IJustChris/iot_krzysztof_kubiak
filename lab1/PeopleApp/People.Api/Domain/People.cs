using System.ComponentModel.DataAnnotations;

namespace People.Api.Domain
{
    public class People
    {

        protected People()
        {
        }

        public People(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }  
        [Required]
        public string Lastname { get; set; }
        public string Fullname =>  $"{this.Firstname} {this.Lastname}";
    }
}