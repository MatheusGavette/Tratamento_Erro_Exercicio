using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
