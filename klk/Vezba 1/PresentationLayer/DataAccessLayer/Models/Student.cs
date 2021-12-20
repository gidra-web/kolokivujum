using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Student
    {
        public int Id { get; set; } //auto svojsta
        public string Name { get; set; }
        public string InexNumber { get; set; }
        public decimal AverageMark { get; set; }

        //sql server .NET maping- mapiranje tipova pod
    }
}
