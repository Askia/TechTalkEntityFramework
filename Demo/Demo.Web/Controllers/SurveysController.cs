using AutoMapper;
using Demo.Data;
using Demo.Web.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Web.Controllers
{
    [ApiController]
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
            throw new NotImplementedException();
        }

        [HttpGet("SurveysWithPreview")]
        public IEnumerable<SurveyDto> GetSurveyWithPreview()
        {
            throw new NotImplementedException();
        }

        [HttpGet("SurveysWithQuestions")]
        public IEnumerable<SurveyDto> GetSurveyWithQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
