using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    static class ExceptionHandler
    {


        public static String HandleException(String sender)
        {
            switch (sender)
            {
                case "DecreaseAmountPlayer":
                    return ShowError("Captain, we don't have more of those goods!");
                case "SelectPort":
                    return ShowError("Yarr, Captain! You must travel to a port first!");
                case "NoGold":
                    return ShowError("Shiver me timbers, Captain! We're out of gold");
            }
            return null;
        }

        public static String ShowError(String error)
        {
            return error;
        }
    }
}