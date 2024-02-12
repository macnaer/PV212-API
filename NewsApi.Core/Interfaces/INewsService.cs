using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface INewsService
    {
        Task Insert(News model);
        Task<List<NewsDto>> GetAll();
        Task<NewsDto> Get(int id);
        Task Update(News news);
        Task Delete(int id);
        Task<List<News>> GetByCategory(int id);
    }
}
