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
            var languages = _dbContext.Languages.ToList();
            var languagesDto = _mapper.Map<IEnumerable<LanguageDto>>(languages);
            return languagesDto;
        }

        [HttpGet("Languages/{id}")]
        public LanguageDto GetLanguage(int idLanguage)
        {
            var language = _dbContext.Languages.Include(l => l.Surveys).SingleOrDefault(l => l.Id == idLanguage);
            var languageDto = _mapper.Map<LanguageDto>(language);
            return languageDto;
        }
    }
}
