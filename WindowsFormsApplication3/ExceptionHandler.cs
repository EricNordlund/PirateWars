using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    class ExceptionHandler
    {


        public void HandleException(String sender)
        {
            switch (sender)
            {
                case "DecreaseAmountPlayer":
                    ShowError("Can't sell because your item is out of stock!");
                    break;
                case "SelectPort":
                    ShowError("Yarr, Captain! You must travel to a port first!");
                    break;
            }
        }

        public void ShowError(String error)
        {
            MessageBox.Show(error);
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