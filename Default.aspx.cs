using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palindromo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Cadena1 = TextBox1.Text;

            string[] Cadena = Cadena1.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int ConteoPalindromos = Cadena.Count(pal => Espalindromo(pal));

            Label1.Text = $"Cantidad de palíndromos encontrados: {ConteoPalindromos}";

        }

        private bool Espalindromo(string palabra)
        {
            int largo = palabra.Length;
            for (int i = 0; i < largo / 2; i++)
            {
                if (palabra[i] != palabra[largo - i - 1])
                    return false;
            }
            return true;

        }
    }
}