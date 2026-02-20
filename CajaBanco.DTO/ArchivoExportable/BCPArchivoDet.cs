using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaBanco.DTO.ArchivoExportable
{
    public class BCPArchivoDet
    {
        public string tipoRegistro { get; set; }
            public string tipoCuentaAbono { get; set; }
            public string nroCuentaAbono { get; set; }
            public string modalidadPago { get; set; }
            public string tipoDocumentoProveedor { get; set; }
            public string numeroDocuProveedor { get; set; }
            public string correlativoProveedor { get; set; }
            public string nombreProveedor { get; set; }
            public string referenciabeneficiario { get; set; }
            public string referenciaempresa { get; set; }
            public string monedaImporteAbonar { get; set; }
            public string importeAbonar { get; set; }
            public string flagValidarIDC { get; set; }
    


    }
}
