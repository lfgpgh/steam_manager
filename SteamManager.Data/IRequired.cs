using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Data
{
    public interface IRequired
    {
        [Required]
        DateTimeOffset CreatedOn { get; set; }

        [Required]
        DateTimeOffset UpdatedOn { get; set; }
    }
}
