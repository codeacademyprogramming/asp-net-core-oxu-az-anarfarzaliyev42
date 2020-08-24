using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteCoreApp.Models
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(4000)")]
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Date { get; set; }
    
        [Required]
        public string FileName { get; set; }
        [Display(Name ="Photo")]
        [Required(ErrorMessage ="Photo is required")]
        [NotMapped]
        public IFormFile FormFile { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int Views { get; set; }

    }
}
