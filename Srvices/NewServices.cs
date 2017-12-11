using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1;
using Srvices.Model;

namespace Srvices
{
    public class NewServices
    {
        private Repository<News> _newsRepository;
        
        public NewServices()
        {
            this._newsRepository = new Repository<News>();
        }

        public List<NewsDto> GetAll()
        {
            var newsDto = _newsRepository.Set().Select(c => new NewsDto
            {
                title = c.title,
                description = c.description,
                userCreate = c.userCreate,
                userModif = c.userModif,
                creationDate = c.creationDate,
                updateDate = c.updateDate,
            }).ToList();

            return newsDto;
        }
    }
}
