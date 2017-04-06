using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling_salesman_problem;

namespace tspwindowsform
{
    class GoogleMapUrlBuilder
    {

        public static string CreateUrl(List<Address> addresses)
        {
            List<string> addressNames = ConvertAddressList(addresses);
           
            string startAddress = addressNames.ElementAt(0);
            List<string> restAddresses = addressNames.GetRange(1, (addressNames.Count-1));

            StringBuilder builder = new StringBuilder();
            builder.Append(GetBaseUrl());
            builder.Append(GetStartAddress(startAddress));
            builder.Append(GetDestinationAddresses(restAddresses));

            return builder.ToString();
        }

        private static string GetBaseUrl()
        {
            return "http://maps.google.hr/maps?";
        }
        private static string GetStartAddress(string startAddress)
        {
            return "saddr=" + startAddress + "&";
        }
        private static string GetDestinationAddresses(List<string> destinations)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("daddr=" + destinations.ElementAt(0));
            for (int i = 1; i < destinations.Count; i++)
            {
                sb.Append("+to:" + destinations.ElementAt(i));
            }
            return sb.ToString();
        }
        private static List<string> ConvertAddressList(List<Address> addressList)
        {
            List<string> addressNames = new List<string>();
            foreach (Address a in addressList)
            {
                addressNames.Add(a.Name);
            }
            return addressNames;
        }
    }
}
