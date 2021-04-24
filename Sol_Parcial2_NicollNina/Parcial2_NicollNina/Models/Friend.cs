using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2_NicollNina.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3,ErrorMessage ="Ingrese entre 3 a 30 caracteres")]
        public String Name { get; set; }
        public String NickName { get; set; }
        public int Birthday { get; set; }
    }
}