using Coupons.Models;
using Coupons.Processes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Coupons.Services
{
    public static class CouponService
    {
        private static List<CouponModel> _coupon;

        public static List<CouponModel> GetCouponData()
        {

            string url = string.Format(URL.CouponsURL, APIKey.CouponsAPIKey);

            //Submit Request
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            //Get Response
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            //Use stream to get the API information
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Read the Stream to the End
                var result = streamReader.ReadToEnd();
                //Get API Data
                _coupon = ParseCouponDataToJSON.PerformParse(result);
            }

            return _coupon;
        }
    }
}
