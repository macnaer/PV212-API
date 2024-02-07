using AutoMapper;
using NewsApi.Core.DTOs;
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
        private readonly IMapper _mapper;

        public NewsService(IRepository<News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;   
        }

        public async Task Delete(int id)
        {
            await _newsRepository.Delete(id);
            await _newsRepository.Save();
        }

        public async Task<News> Get(int id)
        {
            return (News)await _newsRepository.GetByID(id);
        }

        public async Task Insert(News model)
        {
            await _newsRepository.Insert(model);
            await _newsRepository.Save();
        }

        public async Task<List<NewsDto>> GetAll()
        {
            return _mapper.Map<List<NewsDto>>(await _newsRepository.GetAll());
        }

        public async Task Update(News news)
        {
            await _newsRepository.Update(news);
            await _newsRepository.Save();
        }
    }
}
