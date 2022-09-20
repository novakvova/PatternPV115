using _12.Repository.Repositories;
using System;

namespace _12.Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            //Student pavlo = new Student()
            //{
            //    Name = "Павло Морж",
            //    Email = "pvalo@gmail.com",
            //    Phone = "098 23 45 223",
            //    Age = 30
            //};
            //unitOfWork.StudentRepository.Insert(pavlo);

            //foreach(var s in unitOfWork.StudentRepository.Get())
            //{
            //    Console.WriteLine(s);
            //}


            //Teacher max = new Teacher()
            //{
            //    Name = "Пороть Макс",
            //    Subject = "Дизайне схем каналізації"
            //};
            //unitOfWork.TeacherRepository.Insert(max);
            //unitOfWork.TeacherRepository.Delete(1);

            foreach (var s in unitOfWork.TeacherRepository.Get())
            {
                Console.WriteLine(s);
            }



            //AppFileContext appFileContext = new AppFileContext();
            //Student ivan = new Student();
            //ivan.Name = "Іван Васильович";
            //ivan.Email = "ivan@gmail.com";
            //ivan.Age = 12;
            //ivan.Phone = "098 87 67 123";
            //appFileContext.Students.Add(ivan);
            //appFileContext.SaveChanges();



            //GenericRepository<Student> genericRepository = new GenericRepository<Student>(appFileContext);

            //genericRepository.Insert(new Student()
            //{
            //    Name="Котел",
            //    Age=18,
            //    Email="Молодець",
            //    Phone= "098 87 67 123"

            //});

            //var students = genericRepository.Get();
            //foreach(Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //GenericRepository<Teacher> genericRepository = new GenericRepository<Teacher>(appFileContext);
            //genericRepository.Insert(new Teacher()
            //{
            //    Name = "Дубок Петро",
            //    Subject="Прикладна математика"

            //});

            //var teachers = genericRepository.Get();
            //foreach (Teacher teacher in teachers)
            //{
            //    Console.WriteLine(teacher.Name);
            //}

        }
    }
}
