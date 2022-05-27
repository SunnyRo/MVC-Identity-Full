using System.ComponentModel.DataAnnotations;
namespace PlayerWeb.Models
{
        public class Bot {
                [Key]
                public Guid Id { get; set; }
                public string Name {set;get;}
                public string Level {set;get;}
                public Bot() { }
        }

}