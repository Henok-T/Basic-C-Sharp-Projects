using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHLapp.Models.NHL
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }

        public string TeamName { get; set; }
        public Team Team { get; set; }
    }
}