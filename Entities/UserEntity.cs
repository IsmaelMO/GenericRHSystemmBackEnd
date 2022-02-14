using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRHSystemBackEnd.Entities
{
    public class UserEntity
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string userr { get; set; }
        public string passwordd { get; set; }
        public bool status { get; set; }
        public string gender { get; set; }
   //     public DateTime creationDate { get; set; }
    }

}
