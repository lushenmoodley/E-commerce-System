using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.Base;
using WebApplication3.Data.ViewModels;
using WebApplication3.Models;

namespace WebApplication3.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropDownVM> GetNewMovieDropDownValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
