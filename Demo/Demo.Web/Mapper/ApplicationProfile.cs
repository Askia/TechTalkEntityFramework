﻿using AutoMapper;
using Demo.Data.Models;
using Demo.Web.Dtos;

namespace Demo.Web.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Survey, SurveyDto>();
            CreateMap<SurveyPreview, SurveyPreviewDto>()
                  .ForMember(dest => dest.Html, act => act.MapFrom(src => src.HtmlContent));
        }
    }
}
