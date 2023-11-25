using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibra.Models;

public class BorrowedBook
{
    public string UserName { get; set; }
    public Book Book { get; set; }
}
