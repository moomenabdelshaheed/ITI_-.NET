using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay02.Model
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50)]

        public string Name { get; set; }
        [StringLength(50)]

        public string Description { get; set; }

        public virtual List<News> Newsincat { get; set; }
       
    }
}
