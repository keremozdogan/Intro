// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables-->camelCase  -->ilk harf kucuk sonrakıler buyuk harfle baslar.
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition -->koşul
if (isAuthenticated) //if(isAuthenticated==true)'la aynı ==true yazmasanda aynı
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi1","Kredi2","Kredi3","Kredi4","Kredi5","Kredi6" }; //db'den gelir tek tek consolewriteline ile yazilmaz for dongusu acilir.
//string[] loans2 = new string[6]; -->bu sekilde de deger atamasi yapilir.
//string[0]= "Kredi1";

      //start       condition   increment
for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

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

Course[] courses = { course1, course2, course3 };
for(int i = 0;i < courses.Length; i++) 
{
    Console.WriteLine(courses[i].Name + " / "+ courses[i].Price);
}


CourseManager courseManager = new();
Course[] courses2=courseManager.GetAll(); //CourseManagerdaki kursları cagırıyosun.Once oraya metotu yazdık.
for (int i = 0; i < courses2.Length; i++) 
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
Console.WriteLine("kod bitti");