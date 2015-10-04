using Norma43ToContaSol.Model.Norma43;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol
{
    class Norma43Engine
    {
        public Type Norma43Selector(string record)
        {
            string recordTypeId = record.Substring(0, 2);
            Type recordType;
            switch ( recordTypeId )
            {
                case "11":
                    recordType = typeof(CabeceraDeCuenta);
                    break;
                case "22":
                    recordType = typeof(PrincipalDeMovimiento);
                    break;
                case "23":
                    recordType = typeof(ComplementariosConcepto);
                    break;
                case "24":
                    recordType = typeof(ComplementarioInformacionEquivalenciaImporteApunte);
                    break;
                case "33":
                    recordType = typeof(RegistroFinalCuenta);
                    break;
                case "44":
                    recordType = typeof(FinDeFichero);
                    break;
                default:
                    throw new NotImplementedException("Not Implemented record with id " + recordTypeId);
            }
            return recordType;
        }
    }
}
