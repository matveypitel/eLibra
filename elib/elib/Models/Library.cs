using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibra.Models;

public class Library
{
    public List<User> Users { get; set; } = new List<User>();
    public List<Genre> Genres { get; set; } = new List<Genre>();
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Author> Authors { get; set; } = new List<Author>();
}
