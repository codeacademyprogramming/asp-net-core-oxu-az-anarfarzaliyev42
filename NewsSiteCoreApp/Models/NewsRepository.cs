using Microsoft.EntityFrameworkCore;
using NewsSiteCoreApp.Abstractions;
using NewsSiteCoreApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteCoreApp.Models
{
    public class NewsRepository:INewsRepository
    {
        ApplicationContext _db;

        public NewsRepository(ApplicationContext db)
        {
            _db = db;
        }

        public void Create(News news)
        {
            _db.News.Add(news);
            _db.SaveChanges();
        }

        public void Edit(News news)
        {
            _db.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);
            _db.Entry(news).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public List<News> GetAll()
        {
            return _db.News.ToList();
        }

        public void Remove(News news)
        {
            _db.News.Remove(news);
            _db.SaveChanges();
        }
        public bool AddLike(int id)
        {
            News news=_db.News.Find(id);
            news.Likes += 1;
             if (_db.SaveChanges()>0)
             {
                 return true;
             }
                 return false;
        }

        public bool AddDislike(int id)
        {
            News news = _db.News.Find(id);
            news.Dislikes += 1;
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool GetView(int id)
        {
            News news = _db.News.Find(id);
            news.Views += 1;
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public News GetNewsById(int id)
        {
            News news = _db.News.Find(id);
            if ( news!= null)
            {
                return news;
            }
            return null;
        }
    }
}
