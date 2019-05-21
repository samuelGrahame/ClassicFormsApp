using ClassicFormsApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.dom;

namespace ClassicFormsApp
{
    class Program
    {
        static void Main()
        {
            AddMeta("viewport", "width=device-width, initial-scale=1, shrink-to-fit=no");

            AddCss("https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Material+Icons");
            AddCss("https://unpkg.com/bootstrap-material-design@4.1.1/dist/css/bootstrap-material-design.min.css");

            Settings._isUsingBootStrap = true;
            Settings._isUsingMaterial = false;

            window.onload = (ev) =>
            {
                new frmMain().Show();
            };            
        }

        static void AddCss(string source)
        {
            (document.head ?? document.documentElement).appendChild(new HTMLLinkElement
            {
                href = source,
                rel = "stylesheet",
            });            
        }

        static void AddMeta(string name, string content)
        {
            (document.head ?? document.documentElement).appendChild(new HTMLMetaElement
            {
                name = name,
                content = content,
            });
        }
    }
}
