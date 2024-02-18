using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using updateAndChangeState.model;

namespace updateAndChangeState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new context();

            //var logger = new MyLogger();


            //context.Database.Log = s => Debug.WriteLine(s);


            // related delete in the object (if i send collection null)

            var student = new student();
            student.name = "Test2";
            student.description = "aldkfjalsdkjfasdl";
            student.myList = new List<int> { 1, 2, 3 };

            var s = context.Students.Where(r => r.id == 7).Include(d => d.course)
                .AsNoTracking()
                .FirstOrDefault();

            //s.description = "modified";   //connected moded



            //s.course = new course() { description = "adfasd" , name="asdkjfasdklj"};


           // s.description = "adfffsfsd";
            s.course.name = "newccdd";


            //context.Entry(s).State = EntityState.Modified; // not get the related object
            //context.Entry(s).Property(e => e.name).IsModified = true;
            


            
            //context.Add(student);
            
            
            
            
            context.Students.Update(s); // get the realted object

            context.SaveChanges();



        }
    }
}
