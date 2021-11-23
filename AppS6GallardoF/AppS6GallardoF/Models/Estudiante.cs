using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppS6GallardoF.Models
{
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }
        [MaxLength (50)]
        public string Nombre { get; set; }
        [MaxLength (25)]
        public string Usuario { get; set; }
        [MaxLength(25)]
        public string Contrasenia { get; set; }
    }
}
