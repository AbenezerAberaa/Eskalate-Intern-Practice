using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models
{
public class BaseEntity_
{
    public int Id{ get; set; }
    public int Status{ get; set; }
    public DateTime DateAdded{ get; set;}
    public DateTime DataUpdated{ get; set;}

}

}
