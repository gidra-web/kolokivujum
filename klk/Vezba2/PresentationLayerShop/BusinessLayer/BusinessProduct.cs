using DataAccessLayerShop;
using DataAccessLayerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessProduct
    {
        private readonly ProductRepository productRepository;

        public BusinessProduct()
        {
            this.productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAllProducts();
        }
        public bool InsertProduct(Product p)
        {
            if (this.productRepository.InsertProduct(p) > 0)
                return true;
            return false;
        }

        // metoda koja vraca studente koji ispunjavaju uslov avgMark
        public List<Product> GetProductsDnotExpireDate()
        {
            //List<Student> listOfStudents =new List<Student>();
            //foreach(var s in this.studentRepository.GetAllStudents())
            //{
            //    if(s.AverageMark > averageMark)
            //        listOfStudents.Add(s);
            //}
            //return listOfStudents;

            return this.productRepository.GetAllProducts().
                Where(p => DateTime.Now < p.ExpireDate ).ToList();   //using System.Linq;

        }
    }
}
