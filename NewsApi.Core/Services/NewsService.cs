using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News> _newsRepository;

        public NewsService(IRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public Task<News> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<News> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<News>> GetAll()
        {

            return (List<News>)await _newsRepository.GetAll();
        }

        public Task<News> Update(News news)
        {
            throw new NotImplementedException();
        }
    }
}
