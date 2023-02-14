using OttoMicrowave.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.services
{
    public class StringBuilderService
    {
        public static string StringBuilderWithQuickModeChar(QuickMode quickMode)
        {
            var multiply = quickMode.Power;
            var code = quickMode.code;
            string text = "";
            for(int i = 0; i < multiply; i++)
            {
                text += code;
            }
            return text + " ";
        }

        public static string StringBuilderWithQuickModeChar(int power)
        {
            var code = ".";
            string text = "";
            for (int i = 0; i < power; i++)
            {
                text += code;
            }
            return text + " ";
        }
    }
}
