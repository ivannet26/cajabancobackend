using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaBanco.DTO.ArchivoExportable
{
    public  class BCPArchivoCab
    {
            public string tipoRegistro { get; set; }
            public string cantidadAbonoPlanilla { get; set; }
            public string fechaProceso { get; set; }
            public string  tipoCuentaCargo { get; set; }
            public string monedaCuentaCargo { get; set; }
            public string numeroCuentaCargo { get; set; }
            public string  montoTotalPlanilla { get; set; }
            public string referenciaPlaanilla { get; set; }
            public string flagexoneracionitf { get; set; }
            public string totalControl { get; set; }


    }
}
