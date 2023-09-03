using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Actions
    {
        private readonly Logger logger = Logger.Instance;
        private readonly Random random = new Random();

        public Result Method1()
        {
            logger.Log("Info", "Start method: Method1");
            return new Result { Status = true };
        }

        public Result Method2()
        {
            logger.Log("Warning", "Skipped logic in method: Method2");
            return new Result { Status = true };
        }

        public Result Method3()
        {
            logger.Log("Error", "Action failed by a reason: I broke a logic");
            return new Result { Status = false, Error = "I broke a logic" };
        }

        public Result GetRandomMethod()
        {
            int randomValue = random.Next(1, 4);
            switch (randomValue)
            {
                case 1:
                    return Method1();
                case 2:
                    return Method2();
                case 3:
                    return Method3();
                default:
                    return new Result { Status = false, Error = "Unknown method" };
            }
        }
    }
}
