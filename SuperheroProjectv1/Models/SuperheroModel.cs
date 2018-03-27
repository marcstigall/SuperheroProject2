using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroProjectv1.Models
{
    public class SuperheroModel
    {
        public int SuperheroModelId { get; set; }
        [Required]
        public string Power { get; set; }
        public UserModel UserModel { get; set; }
        public string Backstory { get; set; }
        public string Name { get; set; }
    }
}