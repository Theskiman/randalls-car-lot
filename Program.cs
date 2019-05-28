using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            //             "vehicles": [
            //     {
            //         "vehicle": {
            //             "year": 2008,
            //             "model": "Damfresh",
            //             "make": "Biotraxquote",
            //             "color": "sky magenta"
            //         },
            //         "sales_id": "ecb1c841-1a43-4a7c-896e-712d2ec39c71",
            //         "sales_agent": {
            //             "mobile": "(896) 478-6975",
            //             "last_name": "Botsford",
            //             "first_name": "Shaina",
            //             "emails": ["beatae_sonny@hotmail.com", "shaina@aol.com"]
            //         },
            //         "purchase_date": "2017-11-15",
            //         "gross_profit": 871.26,
            //         "credit": {
            //             "credit_provider": "J.P.Morgan Chase & Co",
            //             "account": "601109582720302"
            //         }
            //     },
            //     {
            //         "vehicle": {
            //             "year": 2010,
            //             "model": "Hotquadtrax",
            //             "make": "Transtintechno",
            //             "color": "robin egg blue"
            //         },
            //         "sales_id": "a2f80554-bd9d-4ea1-8229-01fd4cf220a8",
            //         "sales_agent": {
            //             "mobile": "562.300.2912",
            //             "last_name": "Davis",
            //             "first_name": "Gerardo",
            //             "emails": ["girl70@hotmail.com", "jova43@gmail.com"]
            //         },
            //         "purchase_date": "2017-04-28",
            //         "gross_profit": 156.02,
            //         "credit": {
            //             "credit_provider": "PNC Financial Services",
            //             "account": "34578280562836"
            //         }
            //     }
            // ]

            List<Dictionary<string, string>> vehicles = new List<Dictionary<string, string>>()
            {
            };
            Dictionary<string, string> vehicleOne = new Dictionary<string, string>(){
                {"year", "2008"},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "sky magenta"}
    };
            vehicles.Add(vehicleOne);
            Dictionary<string, string> vehicleOneId = new Dictionary<string, string>(){
            {"salesId", "ecb1c841-1a43-4a7c-896e-712d2ec39c71"}

};
            vehicles.Add(vehicleOneId);
            Dictionary<string, string> vehicleOneAgent = new Dictionary<string, string>(){
                {"mobile", "(896) 478-6975"},
                {"lastName", "Botsford"},
                {"firstName", "Shaina"},
                {"emails", "beatae_sonny@hotmail.com, shaina@aol.com"}
            };
            vehicles.Add(vehicleOneAgent);

            Dictionary<string, string> vehicleOnePurchaseProfit = new Dictionary<string, string>(){
                {"purchaseDate", "2017-11-15"},
                {"grossProfit", "871.26"}
            };
            vehicles.Add(vehicleOnePurchaseProfit);

            Dictionary<string, string> vehicleOneCredit = new Dictionary<string, string>()
            {
                {"creditProvider", "J.P.Morgan Chase & Co"},
                {"account", "601109582720302"}
            };
            vehicles.Add(vehicleOneCredit);


            Dictionary<string, string> vehicleTwo = new Dictionary<string, string>(){
                {"year", "2010"},
                {"model", "Hotquadtrax"},
                {"make", "Transtintechno"},
                {"color", "robin egg blue"}
    };
            vehicles.Add(vehicleTwo);
            Dictionary<string, string> vehicleTwoId = new Dictionary<string, string>(){
            {"salesId", "a2f80554-bd9d-4ea1-8229-01fd4cf220a8"}

};
            vehicles.Add(vehicleTwoId);
            Dictionary<string, string> vehicleTwoAgent = new Dictionary<string, string>(){
                {"mobile", "562.300.2912"},
                {"lastName", "Davis"},
                {"firstName", "Gerardo"},
                {"emails", "beatae_sonny@hotmail.com, shaina@aol.com"}
            };
            vehicles.Add(vehicleTwoAgent);

            Dictionary<string, string> vehicleTwoPurchaseProfit = new Dictionary<string, string>(){
                {"purchaseDate", "2017-04-28"},
                {"grossProfit", "156.02"}
            };
            vehicles.Add(vehicleTwoPurchaseProfit);

            Dictionary<string, string> vehicleTwoCredit = new Dictionary<string, string>()
            {
                {"creditProvider", "PNC Financial Services"},
                {"account", "34578280562836"}
            };
            vehicles.Add(vehicleTwoCredit);
        }
    }
}
