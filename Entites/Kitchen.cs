using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Entites
{
    public class Kitchen
    {
        [Required]
        [MaxLength(50)]
        [Key]
        public string User_name { get; set; }
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Pass_word { get; set; }
    }
}
