using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models
{
public class Driver: BaseEntity_
{
    public int TeamId { get; set; }
    public string Name { get; set; } = "";
    public int RacingNumber { get; set; }
    public virtual Team Team {get; set;}
    public virtual DriverMedia DriverMedia {get; set;}
}

}
