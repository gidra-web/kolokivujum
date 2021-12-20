using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBuisness
    {
        private readonly StudentRepository studentRepository;

        public StudentBuisness()
        {
            this.studentRepository = new StudentRepository();
        }
        //instanciramo repositorijum tako sto kreiramo objekat ove repositori klase i na taj nacin smo povezali buisness sa data layerom
        
        //metoda koja vraca sve studente
        public List<Student> getAllStudents()
        {
            return this.studentRepository.GetAllStudents();    //nakacimo se na repositori 
        }
        //metoda koja vrsi unos studenta u bazu

        public bool InsertStudent(Student s)
        {
            if(this.studentRepository.InsertStudent(s)>0)
                return true;
            return false;
        }
       // metoda koja vraca studente koji ispunjavaju uslov avgMark
        public List<Student> GetStudentsGTAverageMark(decimal averageMark)
        {
            //List<Student> listOfStudents =new List<Student>();
            //foreach(var s in this.studentRepository.GetAllStudents())
            //{
            //    if(s.AverageMark > averageMark)
            //        listOfStudents.Add(s);
            //}
            //return listOfStudents;

            return this.studentRepository.GetAllStudents().
                Where(s => s.AverageMark > averageMark).ToList();   //using System.Linq;
                                                                    //ili foreach

            //return this.productRepository.GetAllProducts().
            //Where(p => DateTime.Now < p.ExpireDate).ToList();
        }
    }
}
