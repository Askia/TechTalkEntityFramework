using AutoMapper;
using Demo.Data.Models;
using Demo.Web.Dtos;

namespace Demo.Web.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Survey, SurveyDto>();
            //CreateMap<SurveyPreview, SurveyPreviewDto>()
            //      .ForMember(dest => dest.Html, act => act.MapFrom(src => src.HtmlContent));
            //CreateMap<Languages, LanguageDto>()
            //     .ForMember(dest => dest.SurveyIds, act => act.MapFrom(src => src.Surveys.Select(s => s.Id)));
        }
    }
}
