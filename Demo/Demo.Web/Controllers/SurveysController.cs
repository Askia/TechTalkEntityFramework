using AutoMapper;
using Demo.Data;
using Demo.Web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurveysController : Controller
    {
        private readonly DemoDbContext _dbContext;
        private readonly IMapper _mapper;
        public SurveysController(DemoDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetSurveys")]
        public IEnumerable<SurveyDto> Get()
        {
            var surveys = _dbContext.Surveys.ToList();
            var surveysDto = _mapper.Map<IEnumerable<SurveyDto>>(surveys);
            return surveysDto;
        }
    }
}
