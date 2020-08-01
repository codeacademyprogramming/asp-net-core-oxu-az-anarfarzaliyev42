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
        NewsContext _newsContext;

        public NewsRepository(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public void Create(News news)
        {
            _newsContext.News.Add(news);
            _newsContext.SaveChanges();
        }

        public void Edit(News news)
        {
            _newsContext.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);
            _newsContext.Entry(news).State = EntityState.Modified;
            _newsContext.SaveChanges();
        }

        public List<News> GetAll()
        {
            return _newsContext.News.ToList();
        }

        public void Remove(News news)
        {
            _newsContext.News.Remove(news);
            _newsContext.SaveChanges();
        }
        public bool AddLike(int id)
        {
            News news=_newsContext.News.Find(id);
            news.Likes += 1;
             if (_newsContext.SaveChanges()>0)
             {
                 return true;
             }
                 return false;
        }

        public bool AddDislike(int id)
        {
            News news = _newsContext.News.Find(id);
            news.Dislikes += 1;
            if (_newsContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool GetView(int id)
        {
            News news = _newsContext.News.Find(id);
            news.Views += 1;
            if (_newsContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public News GetNewsById(int id)
        {
            News news = _newsContext.News.Find(id);
            if ( news!= null)
            {
                return news;
            }
            return null;
        }
    }
}
