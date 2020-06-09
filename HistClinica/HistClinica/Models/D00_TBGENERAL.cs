﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class D00_TBGENERAL
    {
        [Key]
        public int idTab { get; set; }
        public string codTab { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public DateTime? fechaCreate { get; set; }
        public string usuCreate { get; set; }
    }
}
