using _12.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Repository
{
    public class UnitOfWork
    {
        AppFileContext appFileContext = new AppFileContext();

        GenericRepository<Student> studentRepository;
        GenericRepository<Teacher> teacherRepository;

        public GenericRepository<Teacher> TeacherRepository
        {
            get 
            {
                if(teacherRepository == null)
                {
                    teacherRepository = new GenericRepository<Teacher>(appFileContext);
                }
                return teacherRepository; 
            }
        }

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    studentRepository = new GenericRepository<Student>(appFileContext);
                }
                return studentRepository;
            }
        }
    }
}
