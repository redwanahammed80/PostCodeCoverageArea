using LearningProject.Model;
using LearningProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace LearningProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCodeController : ControllerBase
    {
        private readonly IPostCodeRepository _postCode;
        public PostCodeController(IPostCodeRepository postCode)
        {
            _postCode = postCode ??
                throw new ArgumentNullException(nameof(postCode));
        }
        [HttpGet]
        [Route("GetAllPostCode")]
        public async Task<IActionResult> Get(int pageNumber,int pageSize)
        {
            return Ok(await _postCode.GetPostCode(pageNumber,pageSize));
        }
        [HttpGet]
        [Route("GetPostCodeByID/{Id}")]
        public async Task<IActionResult> GetPostCodeByID(long Id)
        {
            return Ok(await _postCode.GetPostCodeByID(Id));
        }
        [HttpPost]
        [Route("AddPostCode")]
        public async Task<IActionResult> Post(PostCode dep)
        {
            var result = await _postCode.InsertPostCode(dep);
            if (result.ID == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }
        [HttpPut]
        [Route("UpdatePostCode")]
        public async Task<IActionResult> Put(PostCode dep)
        {
            await _postCode.UpdatePostCode(dep);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeletePostCode")]
        public JsonResult Delete(int id)
        {
            _postCode.DeletePostCode(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
