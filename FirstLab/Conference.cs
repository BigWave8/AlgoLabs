using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace FirstLab
{
    class Conference
    {
        public string Name { get; set; }

        public int CountOfMembers { get; set; }

        public int TicketPriceInHryvnia { get; set; }

        public string City { get; set; }

        // insertion ---> count_of_members descending
        // heapsort ---> ticket_price_in_hryvnia ascending

        public static Conference FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Conference conference = new Conference();
            conference.Name = Convert.ToString(values[0]);
            conference.CountOfMembers = Convert.ToInt32(values[1]);
            conference.TicketPriceInHryvnia = Convert.ToInt32(values[2]);
            conference.City = Convert.ToString(values[3]);
            return conference;
        }
    }
}
