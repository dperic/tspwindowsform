using System.Collections.Generic;

namespace traveling_salesman_problem
{
    interface IGoogleMapUrlBuilder
    {
        string CreateUrl(List<Address> addresses);
    }
}