using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public class Subscription
    {
        public int FanId { get; set; }
        public string SportClubId { get; set; }

    }
}
