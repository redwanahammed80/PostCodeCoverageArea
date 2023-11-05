using LearningProject.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningProject.Repository
{
    public interface IPostCodeRepository
    {
        Task<IEnumerable<PostCode>> GetPostCode(int pageNumber,int pageSize);
        Task<PostCode> GetPostCodeByID(long ID);
        Task<PostCode> InsertPostCode(PostCode objPostCode);
        Task<PostCode> UpdatePostCode(PostCode objPostCode);
        bool DeletePostCode(int ID);
    }
}
