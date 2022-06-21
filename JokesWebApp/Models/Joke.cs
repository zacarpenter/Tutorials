using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }

        [Display(Name = "Joke")]
        public string JokeQuestion { get; set; }

        [Display(Name = "Answer")]
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
