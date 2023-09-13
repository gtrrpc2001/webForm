using cubemeslight;
using cubemesweb.dair_mobile;
using cubemesweb.dair_wrapdust;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;
using Wisej.Web;

namespace cubemesweb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Title = "";

            cs.LogInit();

            Application.LoadTheme("Clear-3");

            Application.ApplicationRefresh += Application_ApplicationRefresh;

            Application_ApplicationRefresh(null, null);
        }

        static void Application_ApplicationRefresh(object sender, EventArgs e)
        {
            try
            {
                string url = Application.Uri.ToString();

                if (false)
                {

                }
                else
                {
                    FormLoginMobile f = new FormLoginMobile() { Name = Application.SessionId + ".FormLoginMobile" };
                    Application.MainPage = f;
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }
    }
}