using NewsSiteCoreApp.Contexts;
using NewsSiteCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteCoreApp.Abstractions
{
    public interface INewsRepository
    {
        List<News> GetAll();
        void Create(News news);
        void Edit(News news);
        void Remove(News news);

        bool AddLike(int id);
        bool AddDislike(int id);

        bool GetView(int id);

        News GetNewsById(int id);
    }
}
