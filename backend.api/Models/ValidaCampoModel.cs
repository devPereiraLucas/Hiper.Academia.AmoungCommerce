using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.api.Models
{
    public class ValidaCampoModel
    {
        public IEnumerable<string> Erros { get; set; }

        public ValidaCampoModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
