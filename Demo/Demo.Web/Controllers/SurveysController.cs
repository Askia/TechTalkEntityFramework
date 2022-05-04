using AutoMapper;
using Demo.Data;
using Demo.Web.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Web.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class SurveysController : Controller
    {
        private readonly DemoDbContext _dbContext;
        private readonly IMapper _mapper;
        public SurveysController(DemoDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("Surveys")]
        public IEnumerable<SurveyDto> Get()
        {
            var surveys = _dbContext.Surveys.ToList();
            var surveysDto = _mapper.Map<IEnumerable<SurveyDto>>(surveys);
            return surveysDto;
        }

        [HttpGet("SurveysWithPreview")]
        public IEnumerable<SurveyDto> GetExtendedSurvey()
        {
            var surveys = _dbContext.Surveys.Include(s => s.SurveyPreview).ToList();
            var surveysDto = _mapper.Map<IEnumerable<SurveyDto>>(surveys);
            return surveysDto;
        }
    }
}
