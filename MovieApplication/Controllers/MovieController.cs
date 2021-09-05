using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Models;
using MovieApplication.Repository.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Controllers
{

    [ApiController]
    [AllowAnonymous]
    [EnableCors("AllowOrigin")]
    [Route("movie")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _movieRepo;

        public MovieController(IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
        }

        [HttpGet]
        public MovieWrapper Get()
        {
            return _movieRepo.GetMovie();
        }
    }
}
