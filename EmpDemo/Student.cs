using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{
    public class Student
    {
        [Key]
      //  [DisplayName("StudentID")]
        public int Id { get; set; }
       
        public string? Name { get; set; }

     //   [Required(ErrorMessage ="THis is a required fi")]
        public string? Title { get; set; }

        public int Age { get; set; }

        

       
    }
}
