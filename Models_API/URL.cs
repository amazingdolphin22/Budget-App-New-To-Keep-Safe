using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupons.Models
{
    public static class URL
    {
        public static string CouponsURL { get; } = "https://api.discountapi.com/v2/deals?api_key={0}";
    }
}
