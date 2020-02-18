using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioTratamentoDeExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
