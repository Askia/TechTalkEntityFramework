namespace Demo.Web.Dtos
{
    public class LanguageDto
    {
        public string Name { get; set; }

        public IEnumerable<int> SurveyIds { get; set; }
    }
}
