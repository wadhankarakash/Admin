using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServices.Models;
using SchoolAdmin.Models;

namespace SchoolAdminBusiness
{
    public class Search
    {
        public List<Student> SearchStudent(SearchStudentRequests searchRequest)
        {
            SearchResponse searchResponse = new SearchResponse();
            //Call to stored proc from data Access layer to get data
            List<Student> lsStudent = new List<Student>();
            lsStudent.Add(new Student() { FirstName="akash",LastName="wadhankar1",Age="20", Div="E"});
            lsStudent.Add(new Student() { FirstName = "akash1", LastName = "wadhankar2", Age = "21", Div = "A"});
            lsStudent.Add(new Student() { FirstName = "akash2", LastName = "wadhankar3", Age = "22", Div = "B" });
            lsStudent.Add(new Student() { FirstName = "akash3", LastName = "wadhankar4", Age = "23", Div = "C" });
            lsStudent.Add(new Student() { FirstName = "akash4", LastName = "wadhankar5", Age = "24", Div = "D" });
            return lsStudent;
        }

        public List<Student> SearchTeacher(SearchTeacherRequests searchRequest)
        {
            SearchResponse searchResponse = new SearchResponse();
            //Call to stored proc from data Access layer to get data
            List<Student> lsStudent = new List<Student>();
            lsStudent.Add(new Student() { FirstName = "akash", LastName = "wadhankar1", Age = "20", Div = "E" });
            lsStudent.Add(new Student() { FirstName = "akash1", LastName = "wadhankar2", Age = "21", Div = "A" });
            lsStudent.Add(new Student() { FirstName = "akash2", LastName = "wadhankar3", Age = "22", Div = "B" });
            lsStudent.Add(new Student() { FirstName = "akash3", LastName = "wadhankar4", Age = "23", Div = "C" });
            lsStudent.Add(new Student() { FirstName = "akash4", LastName = "wadhankar5", Age = "24", Div = "D" });
            return lsStudent;
        }
    }
}
