using InspirinngQuotes_Test_1.dbcontext;
using InspirinngQuotes_Test_1.Models;
using Microsoft.EntityFrameworkCore;

namespace InspirinngQuotes_Test_1.Services
{
    public interface ItagsService
    {
        Task AddNewTags(Tags tags);
        Task <List<Tags>> GetAllTags();
        Task UpdateTags (Tags tags);
        Task DeleteTags (Int32 id);

    }
    public class TagsService : ItagsService
    {
        public async Task AddNewTags(Tags tags)
        {
            using(var context=new AppDbContext())
            {
               await context.tags.AddAsync(tags);
               await context.SaveChangesAsync();
            }
        }

        public async Task UpdateTags(Tags tags)
        {
            using (var context = new AppDbContext())
            {
                context.tags.Update(tags);
                await context.SaveChangesAsync();
            }
        }

        public async Task <List<Tags>> GetAllTags()
        {
            using (var context = new AppDbContext())
            {
                return await context.tags.ToListAsync();
               
            }
        }

        public async Task DeleteTags(int id)
        {
            using (var context = new AppDbContext())
            {
               var oldTask = await context.tags.FindAsync(id);
                if(oldTask!=null)
                {
                   context.tags.Remove(oldTask);
                   await context.SaveChangesAsync();
                }
            }
        }
    }
}
