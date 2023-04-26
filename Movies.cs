using MoviesAPI.Controllers;

namespace JURNAL_MOD9_1302213091_AFF
{
    public class Movie
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public List<string> Stars { get; set; }

        public string Description { get; set; }

        public Movie(string Title, string Director, List<string> Stars, string Description)
        {
            Title = Title;
            Director = Director;
            Stars = Stars;
            Description = Description;
        }
    }
}