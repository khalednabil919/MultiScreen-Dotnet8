using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiScreen_Dotnet8.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedGradeandTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
    table: "Grades",
    columns: new[] { "Id", "Name" },
    values: new object[,]
    {
         { 1, "First" },
         { 2, "Second" },
         { 3, "Third" },
         { 4, "fourth" },
    });

            migrationBuilder.InsertData(
               table: "Teachers",
               columns: new[] { "Id", "Name", "GradeId" },
               values: new object[,]
               {
             { 1, "Khaled",1 },
             { 2, "Shaker",1 },
             { 3, "Mahmoud",1 },
             { 4, "Amr",2 },
             { 5, "Osama",2 },
             { 6, "Ahmed",2 },
             { 7, "yousef",3 },
             { 8, "zean",3 },
             { 9, "derby",3 },
             { 10, "Magdy",4 },
             { 11, "Nabil",4 },
             { 12, "Hassan",4 }
               });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
