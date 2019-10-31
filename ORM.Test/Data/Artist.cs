using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ORM.Test.Data
{
    public class Artist
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}