using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    class ExceptionHandler
    {


        public String HandleException(String sender)
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

        public String ShowError(String error)
        {
            return error;
        }
    }
}
/*
 * 
 try
 {
  Göra något
 }
 catch(Exception e)
 {
   ExceptionHandler.HandleException("Fel på något", e);
 }

*/