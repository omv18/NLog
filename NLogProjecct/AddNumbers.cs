using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProjecct
{
    internal class AddNumbers
    {
        private readonly NLog nLog = new NLog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if(firstNumber == 0|| secondNumber == 0)
            {
                nLog.LogDebug("Debug Succesfull : Sum()");
                nLog.LogError("expecting null values");
                nLog.LogWarn("Second or secondNumber should not equal to 0");
            }
            int result = secondNumber + secondNumber;
            nLog.LogDebug("Debug Successfully : Sum()");
            nLog.LogInfo("Sum Method passed , Result "+ result);
            return result;
        }
    }
}
