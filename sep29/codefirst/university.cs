using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDALDemo
{
    public class Member
    {
        [Key]
        [Required]
        public int Memberid { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string Membername { get; set; }


        //1 Student---M Enrollments
        public virtual ICollection<Issues> Issues { get; set; }



    }

    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string BookName { get; set; }

        [Range(100, 200, ErrorMessage = "not in range")]
        public int Cost { get; set; }
        //1 course---- M enrollments
        public virtual ICollection<Issues> Issues { get; set; }

    }

    public class Issues
    {
        [Key]
        public int IssueID { get; set; }
        public int BookID { get; set; }
        public int Memberid { get; set; }

        [ForeignKey("BookID")]
        public virtual Book bookDetails { get; set; }
        [ForeignKey("Memberid")]
        public virtual Member memberDetails { get; set; }


    }

    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
        }

        public virtual DbSet<Member> MemberTable { get; set; }
        public virtual DbSet<Book> BookTable { get; set; }
        public virtual DbSet<Issues> IssueTable { get; set; }

    }

}
