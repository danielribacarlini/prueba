using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1;
using Srvices.Model;

namespace Srvices
{
    public class UsersServices
    {
        private Repository<users> _usersRepository;
        private Repository<News> _newsRepository;

        public UsersServices()
        {
            this._usersRepository = new Repository<users>();
            this._newsRepository = new Repository<News>();
        }

        public List<UsersDto> GetAll()
        {
            var usersDto = _usersRepository.Set().Select(c => new UsersDto
            {
                userName= c.userName,
                password = c.password,
            }).ToList();

            return usersDto;
        }

        public void Save(UsersDto user)
        {
            var newUser = new users
            {
                userName = user.userName,
                password = user.password
            };

            _usersRepository.Persist(newUser);
            _usersRepository.SaveChanges();
        }

        public void Update(UsersDto userP)
        {
            var user = _usersRepository.Set().FirstOrDefault(c => c.userName == userP.userName);

            user.userName = userP.userName;
            user.password = userP.password;

            _usersRepository.SaveChanges();

        }

        public void Delete (string userName)
        {
            var user = _usersRepository.Set().FirstOrDefault(c => c.userName == userName);

            var news = _newsRepository.Set().Any(c => c.userCreate == userName);

            if (news)
                throw new Exception("No se puede borrar el usuario");

            _usersRepository.Remove(user);
            _usersRepository.SaveChanges();
        }

        public UsersDto GetOne(string userName)
        {
            var user = _usersRepository.Set().FirstOrDefault(c => c.userName == userName);

            var usernew = new UsersDto
            {
                userName = user.userName,
                password = user.password
            };

            return usernew;
        }
    }
}
