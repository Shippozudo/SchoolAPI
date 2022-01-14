using Microsoft.EntityFrameworkCore.Migrations;

namespace EFContext.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassAndCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ClassName = table.Column<int>(type: "NUMBER(10)", maxLength: 3, nullable: false),
                    CourseName = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAndCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<int>(type: "NUMBER(10)", maxLength: 3, nullable: false),
                    idCourse = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CourseId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Course = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LessonName = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    idTeacher = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentAndLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StudentId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    StudentName = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CourseName = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClassName = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAndLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StudentId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LessonId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CourseId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    IdClassroom = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    IdCourse = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassAndCourses_ClassName",
                table: "ClassAndCourses",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAndCourses_CourseName",
                table: "ClassAndCourses",
                column: "CourseName");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_idCourse",
                table: "Classrooms",
                column: "idCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_Name",
                table: "Classrooms",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_Course",
                table: "CourseLessons",
                column: "Course");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_idTeacher",
                table: "Lessons",
                column: "idTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LessonName",
                table: "Lessons",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAndLessons_ClassName",
                table: "StudentAndLessons",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAndLessons_CourseName",
                table: "StudentAndLessons",
                column: "CourseName");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAndLessons_StudentId",
                table: "StudentAndLessons",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAndLessons_StudentName",
                table: "StudentAndLessons",
                column: "StudentName");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseClasses_ClassId",
                table: "StudentCourseClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseClasses_CourseId",
                table: "StudentCourseClasses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseClasses_LessonId",
                table: "StudentCourseClasses",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseClasses_StudentId",
                table: "StudentCourseClasses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Name",
                table: "Students",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Name",
                table: "Teachers",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassAndCourses");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "CourseLessons");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "StudentAndLessons");

            migrationBuilder.DropTable(
                name: "StudentCourseClasses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
