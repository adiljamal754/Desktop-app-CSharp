using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Csharp.Model
{
    internal class validacao
    {
        ErrorProvider error = new ErrorProvider();

        public void validar(TextBox txt, string mens)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Focus();
                error.SetError(txt, mens);
            }
            else
            {
                error.SetError(txt, null);
            }
        }
    }
}
