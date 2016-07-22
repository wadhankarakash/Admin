using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonServices.Models
{
    public class SearchStudentRequests
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Class { get; set; }
        public string Division { get; set; }
    }

    public class SearchResponse
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Class { get; set; }
        public string Division { get; set; }
    }

    public class SearchTeacherRequests
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Class { get; set; }
        public string Division { get; set; }
    }

    public class SearchAlertRequests
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }

    public class SearchAttendanceRequests
    {
        public string Class { get; set; }
        public string Division { get; set; }
        public string Date { get; set; }
        public string StudentName { get; set; }
    }
}