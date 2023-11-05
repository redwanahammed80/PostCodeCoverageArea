using LearningProject.Context;
using LearningProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProject.Repository
{
    public class PostCodeRepository: IPostCodeRepository
    {
        private readonly APIDbContext _appDBContext;

      
        public PostCodeRepository(APIDbContext context) 
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<PostCode>> GetPostCode(int pageNumner, int pageSize)
        {
            var x = await _appDBContext.postCodes.ToListAsync();

            if (x.Count != 0)
            {
                var y = x.Skip((pageNumner - 1) * pageSize).Take(pageSize);

                return y;
            }
            else 
            {
                return x;
            }
            
        }

        public async Task<PostCode> GetPostCodeByID(long ID)
        {
            return await _appDBContext.postCodes.FindAsync(ID);
            
        }

        public async Task<PostCode> InsertPostCode(PostCode objPostCode)
        {
            _appDBContext.postCodes.Add(objPostCode);
            await _appDBContext.SaveChangesAsync();
            return objPostCode;
        }

        public async Task<PostCode> UpdatePostCode(PostCode objPostCode)
        {
            _appDBContext.Entry(objPostCode).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return objPostCode;
        }

        public bool DeletePostCode(int ID)
        {
            bool result = false;
            var postCode = _appDBContext.postCodes.Find(ID);
            if (postCode != null)
            {
                _appDBContext.Entry(postCode).State = EntityState.Deleted;
                _appDBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
