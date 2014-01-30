﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    class ExceptionHandler
    {


        public void HandleException(String sender, Exception e)
        {
            switch (sender)
            {
                case "x":
                    ShowError("");
                    break;
                case "y":
                    ShowError("");
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