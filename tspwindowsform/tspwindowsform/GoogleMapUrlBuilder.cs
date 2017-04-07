using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling_salesman_problem;

namespace traveling_salesman_problem
{
    class GoogleMapUrlBuilder : IGoogleMapUrlBuilder
    {

        public string CreateUrl(List<Address> addresses)
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

        private string GetBaseUrl()
        {
            return "http://maps.google.hr/maps?";
        }
        private string GetStartAddress(string startAddress)
        {
            return "saddr=" + startAddress + "&&";
        }
        private string GetDestinationAddresses(List<string> destinations)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("daddr=" + destinations.ElementAt(0));
            for (int i = 1; i < destinations.Count; i++)
            {
                sb.Append("+to:" + destinations.ElementAt(i));
            }
            return sb.ToString();
        }
        private List<string> ConvertAddressList(List<Address> addressList)
        {
            List<string> addressNames = new List<string>();
            foreach (Address a in addressList)
            {
                addressNames.Add(a.Name.Replace(" ", "+"));
            }
            return addressNames;
        }
    }
}
