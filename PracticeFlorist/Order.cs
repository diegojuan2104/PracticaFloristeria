using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFlorist
{
    public class Order
    {
        String idCourier, destiny, type;
        int cost;

        public Order(string idCourier, string destiny, string type, int cost)
        {
            this.idCourier = idCourier;
            this.destiny = destiny;
            this.type = type;
            this.cost = cost;
        }

        public string Destiny
        {
            get
            {
                return destiny;
            }

            set
            {
                destiny = value;
            }
        }

        public string IdCourier
        {
            get
            {
                return idCourier;
            }

            set
            {
                idCourier = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }
    }
}
