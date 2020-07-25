using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsApi.Models
{
    [Table("students")]
    public class Student
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("age")]
        public int Age { get; set; }
    }
}
