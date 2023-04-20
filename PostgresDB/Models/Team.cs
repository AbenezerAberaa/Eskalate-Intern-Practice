using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgresDb.Models;


namespace PostgresDb.Models
{
public class Team : BaseEntity_
{
    public Team()
    {
        Drivers = new HashSet<Driver>();
    }
    public string Name { get; set; } = "";
    public int Year { get; set; } = 2022;
    public virtual ICollection<Driver> Drivers{ get; set;}
}
}
