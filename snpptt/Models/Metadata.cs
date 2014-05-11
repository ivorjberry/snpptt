using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace snpptt.Models
{
    public class UserMetadata
    {
        [StringLength(50)]
        public string Username;
    }
}