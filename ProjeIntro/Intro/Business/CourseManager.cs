using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3]; 
    //constructor
    public CourseManager() // ctor ile hazir gelir ve Program.cs'deki--> new(); ifadeden oturu calisir.
    {
        Course course1 = new Course();  
        course1.Id = 1;
        course1.Name = "asd";
        course1.Description = ".NET 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();  
        course1.Id = 2;
        course1.Name = "JAVA";
        course1.Description = "JAVA 17 vs...";
        course1.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12 vs...";
        course3.Price = 20;
        
        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
        public Course[] GetAll()  //Metot deniyor.CourseManagerin icindeki kurslari getir diyorsun.GetAll'u cagıran kısıye Coursları ver demektır
        {
            return courses;

    
}
