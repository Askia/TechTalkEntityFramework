using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    public partial class AddSurveyPreviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyPreview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyPreview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyPreview_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyPreview_SurveyId",
                table: "SurveyPreview",
                column: "SurveyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyPreview");
        }
    }
}
