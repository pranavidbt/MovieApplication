using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Repository.DataAccess
{
    public interface IMovieRepo
    {
        MovieWrapper GetMovie();
    }
}
