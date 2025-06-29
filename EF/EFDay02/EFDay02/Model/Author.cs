using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// عشان تعمل auto increment for pk لو مش معمول

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay02.Model
{
    public class Author
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // كدة انت بتعمله identity
        public int Id { get; set; }
        [StringLength(50)]

        public string Name { get; set; }
        [StringLength(50)]

        public string email { get; set; }
        [StringLength(50)]

        public string password { get; set; }

        public virtual List<News> News { get; set; }
    }
}
