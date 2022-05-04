using AutoMapper;
using Demo.Data;
using Demo.Web.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Web.Controllers
{
    [ApiController]
    public class LanguagesController : Controller
    {
        private readonly DemoDbContext _dbContext;
        private readonly IMapper _mapper;
        public LanguagesController(DemoDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("Languages")]
        public IEnumerable<LanguageDto> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Languages/{idLanguage:int}")]
        public LanguageDto GetLanguage(int idLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
