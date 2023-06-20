using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace Service.Repository
{
    public class RepositoryBase<T> where T : class
    {
        StudentInfoContext studentInfoContext;
        DbSet<T> _DbSet;
        public RepositoryBase()
        {
            studentInfoContext = new StudentInfoContext();
            _DbSet = studentInfoContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return _DbSet.ToList();
        }
        public void Create(T entity)
        {
            _DbSet.Add(entity);
            studentInfoContext.SaveChanges();
        }
        public void Update(T entity)
        {
            var tracker = studentInfoContext.Attach(entity);
            tracker.State = EntityState.Modified;
            studentInfoContext.SaveChanges();
        }
        public bool Delete(T entity)
        {
            try
            {
                _DbSet.Remove(entity);
                studentInfoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
