using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFlorist
{
   public class Courier
    {
        String id, name, city;
        int maxOrders, attendedOrders;
        double totalMoney;
        String avalible;

        public Courier(string id, string name, string city, int maxOrders, int attendedOrders,String avalible,double totalMoney)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.maxOrders = maxOrders;
            this.attendedOrders = attendedOrders;
            this.avalible = avalible;
            this.totalMoney = totalMoney;
        }

        public int AttendedOrders
        {
            get
            {
                return attendedOrders;
            }

            set
            {
                attendedOrders = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int MaxOrders
        {
            get
            {
                return maxOrders;
            }

            set
            {
                maxOrders = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Avalible
        {
            get
            {
                return avalible;
            }

            set
            {
                avalible = value;
            }
        }

        public double TotalMoney
        {
            get
            {
                return totalMoney;
            }

            set
            {
                totalMoney = value;
            }
        }
    }
}
