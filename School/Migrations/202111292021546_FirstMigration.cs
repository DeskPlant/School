namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Single(nullable: false),
                        Subject = c.String(),
                        Student_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_Id = c.Guid(nullable: false),
                        Student_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Student_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Grades", "Student_Id", "dbo.Students");
            DropIndex("dbo.TeacherStudents", new[] { "Student_Id" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_Id" });
            DropIndex("dbo.Grades", new[] { "Student_Id" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
