using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>()
        {
            new Movie { Title = "The Shawshank Redemption", Director = "Frank Darabont", Stars = new List<string> { " Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }, Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion." },
            new Movie { Title = "The Godfather", Director = "Francis Ford Coppola", Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" }, Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.\n\n" },
            new Movie { Title = "The Dark Knight", Director = "Christopher Nolan", Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" }, Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice." },
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok(movies);
        }

        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            movies.Add(movie);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Movie movie)
        {
            movies[id] = movie;
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            movies.RemoveAt(id);
            return Ok();
        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }
        public Movie() { }
    }
}