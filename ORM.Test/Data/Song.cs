using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ORM.Test.Data
{
    public class Song
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string Name { get; set; }

        [DefaultValue(2)]
        public double Lenght { get; set; }

        public string Description { get; set; }

        public string Albom { get; set; }

        public  virtual Artist Artist { get; set; }
    }
}