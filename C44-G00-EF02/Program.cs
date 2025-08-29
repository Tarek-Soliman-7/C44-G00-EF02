using C44_G00_EF02.Data;
using C44_G00_EF02.DataSeeding;
using C44_G00_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace C44_G00_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using SystemDbContext dbContext = new SystemDbContext();
            #region Part1

            #region DataSeeding
            //var flag = ITIDbContextSeed.SeedData(dbContext);
            //if (flag)
            //    Console.WriteLine("Done");
            //else
            //    Console.WriteLine("Not Completed"); 
            #endregion

            #region Invalid Loading Of The Data
            //var StudentWithDepartment = dbContext.Students.FirstOrDefault(S => S.Dep_Id == 1);

            //if (StudentWithDepartment is not null)
            //{
            //    Console.WriteLine($"Student Name Is : {StudentWithDepartment.FName + StudentWithDepartment.LName}");
            //    Console.WriteLine($"Dept Id Is : {StudentWithDepartment.Dep_Id}");
            //    Console.WriteLine($"Dept Name Is : {StudentWithDepartment.Department?.Name}");
            //} 
            #endregion

            #region Loading Related Data

            #region Eager Loading
            ////Ex01
            //var StudentWithDepartment = dbContext.Students.Include(E=>E.Department).FirstOrDefault(S => S.Dep_Id == 1);

            //if (StudentWithDepartment is not null)
            //{
            //    Console.WriteLine($"Student Name Is : {StudentWithDepartment.FName + StudentWithDepartment.LName}");
            //    Console.WriteLine($"Dept Id Is : {StudentWithDepartment.Dep_Id}");
            //    Console.WriteLine($"Dept Name Is : {StudentWithDepartment.Department?.Name}");
            //}

            ////Ex02
            //var InstWithDept=dbContext.Departments.Include(D => D.Manager).ThenInclude(I => I.MangedDepartment)
            //    .FirstOrDefault(D=>D.Ins_ID==1);

            //if (InstWithDept is not null)
            //{
            //    Console.WriteLine($"Dept Name Is : {InstWithDept.Name}");
            //    Console.WriteLine($"Ins Id Is : {InstWithDept.Ins_ID}");
            //    Console.WriteLine($"Ins Name Is : {InstWithDept.Manager?.Name}");
            //}

            ////Ex03
            //var temp=dbContext.Students.Include(S=>S.Department)
            //    .Where(S=>S.Department.Name!= "Computer Science")
            //    .Select(S => new
            //    {
            //        StuName=S.FName+' '+S.LName,
            //        DepartmentID=S.Dep_Id,
            //        DepartmentName=S.Department.Name,
            //    });

            //foreach (var s in temp)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region Explicit Loading
            ////Ex01
            //var StudentWithDepartment = dbContext.Students.FirstOrDefault(S => S.Dep_Id == 1);

            //dbContext?.Entry(StudentWithDepartment!).Reference(S=>S.Department).Load();
            //if (StudentWithDepartment is not null)
            //{
            //    Console.WriteLine($"Student Name Is : {StudentWithDepartment.FName + StudentWithDepartment.LName}");
            //    Console.WriteLine($"Dept Id Is : {StudentWithDepartment.Dep_Id}");
            //    Console.WriteLine($"Dept Name Is : {StudentWithDepartment.Department?.Name}");
            //}

            //Ex02
            //var model = dbContext.Departments.FirstOrDefault(D=>D.ID==1);
            //dbContext?.Entry(model!).Collection(D => D.Instructors).Load();
            //Console.WriteLine(model!.Name);
            //foreach(var ins in model!.Instructors)
            //    Console.WriteLine(ins.Name);

            #endregion

            #region Lazy Loading
            //var StudentWithDepartment = dbContext.Students.FirstOrDefault(S => S.Dep_Id == 1);

            //if (StudentWithDepartment is not null)
            //{
            //    Console.WriteLine($"Student Name Is : {StudentWithDepartment.FName + StudentWithDepartment.LName}");
            //    Console.WriteLine($"Dept Id Is : {StudentWithDepartment.Dep_Id}");
            //    Console.WriteLine($"Dept Name Is : {StudentWithDepartment.Department?.Name}");
            //} 

            #endregion


            #endregion

            #region Join
            #region InnerJoin
            //var res = from D in dbContext.Departments
            //          join S in dbContext.Students
            //          on D.ID equals S.Dep_Id
            //          select new
            //          {
            //              StudentId = S.ID,
            //              StudentName = S.FName + ' ' + S.LName,
            //              DepartmentId = S.Dep_Id,
            //              DepartmentName = D.Name
            //          };


            //var res = dbContext.Departments.Join(dbContext.Students,
            //    D => D.ID, S => S.Dep_Id,
            //    (D, S) => new
            //    {
            //        StudentId = S.ID,
            //        StudentName = S.FName + ' ' + S.LName,
            //        DepartmentId = S.Dep_Id,
            //        DepartmentName = D.Name
            //    }); 
            #endregion

            #region GroupJoin
            ////Ex01
            //var res = from D in dbContext.Departments
            //           join S in dbContext.Students
            //           on D.ID equals S.Dep_Id
            //           into S
            //           select new { D, S }
            //           into X
            //           where X.S.Count()>0
            //           select X;

            ////Ex01
            //var res = dbContext.Departments.GroupJoin(dbContext.Students,
            //    D=>D.ID,
            //    S=>S.Dep_Id,
            //    (D, S) => new
            //    {
            //        D, S
            //    }).Where(X=>X.S.Count()>0);

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"DeptID: {item.D.ID}, DeptName: {item.D.Name}.  ");
            //    foreach( var item2 in item.S)
            //    {
            //        Console.WriteLine($"----StudID: {item2.ID}, StudName: {item2.FName+' '+item2.LName}.");
            //    }
            //}
            #endregion

            #region Left Join

            #endregion

            #region Cross Join

            #endregion
            //foreach (var item in res)
            //    Console.WriteLine(item);


            #endregion
            #endregion

            #region Part2

            #region Create [Insert]
            //List<Student> students = new()
            //{
            //    new Student{FName="Tarek",LName="Soliman",Address="Qena",Age=21,Dep_Id=1},
            //    new Student{FName="Rana",LName="Hatem",Address="Helwan",Age=23,Dep_Id=5},
            //    new Student{FName="Abdelrahman",LName="Alaa",Address="Aswan",Age=21,Dep_Id=3},
            //};
            //dbContext.Students.AddRange(students);
            #endregion

            #region Read/Retrive
            //    var Std=(from S in dbContext.Students
            //             where S.ID ==6
            //             select S).FirstOrDefault();
            //Console.WriteLine(Std?.FName+' '+Std?.LName);
            #endregion

            #region Update
            //var Std= (from S in dbContext.Students
            //         where S.ID ==7
            //         select S).FirstOrDefault();
            //Std!.Address = "Giza";
            #endregion

            #region Delete
            //var Std = (from S in dbContext.Students
            //           where S.ID == 8
            //           select S).FirstOrDefault();
            //dbContext.Students.Remove(Std!);
            #endregion

            //dbContext.SaveChanges(); 
            #endregion

        }
    }
}
