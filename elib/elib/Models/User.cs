using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibra.Models;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
    public string BorrowedBooksDisplay
    {
        get
        {
            return string.Join(", ", BorrowedBooks.Select(b => b.Book.Title));
        }
    }
}
