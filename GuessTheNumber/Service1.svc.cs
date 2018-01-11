using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GuessTheNumber
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        public int secretNumber(int min, int max)
        {

            DateTime currentDate = DateTime.Now;

            int seed = (int)currentDate.Ticks;

            Random random = new Random(seed);

            int sNumber = random.Next(min, max);

            return sNumber;

        }


        public string checkNumber(int userNum, int secretNum)
        {
            if (userNum == secretNum)

                return "correct!";

            else

                if (userNum > secretNum)

                return "too big";

            else

                if (userNum > secretNum)

                return "too big!";

            else

                return "too small!";


                  

            
 
        }
    }
}

      
    

