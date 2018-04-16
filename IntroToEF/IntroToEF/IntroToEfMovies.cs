using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{

    public class IntroToEfMovies
    {
        /*
         * PK ID
         * nvarchar(50) Title
         * int YearReleased
         * nvarChar(50) Genre
         * nvarChar(50) Tagline
         * int Rating
         * */
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public int Rating { get; set; }
    }
}
