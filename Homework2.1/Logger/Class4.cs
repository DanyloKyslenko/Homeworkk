using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    {
        public void Run()
        {
            Logger logger = Logger.Instance;
            Actions actions = new Actions();

            for (int i = 0; i < 100; i++)
            {
                Result result = actions.GetRandomMethod();

                if (!result.Status)
                {
                    logger.Log("Error", $"Action failed by a reason: {result.Error}");
                }
            }

            logger.PrintLogsToFile("log.txt");
        }
    }
}
