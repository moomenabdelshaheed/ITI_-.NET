using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFDay02.Model
{
    public class News
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string   Title { get; set; }
        [StringLength(50)]


        public string bref { get; set; }
        [StringLength(250)]

        public string Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateTime { get; set; }

        [ForeignKey("Category")]
        public int CatId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }
    }
}
