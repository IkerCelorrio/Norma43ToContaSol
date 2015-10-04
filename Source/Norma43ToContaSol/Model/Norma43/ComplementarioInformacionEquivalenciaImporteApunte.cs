using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class ComplementarioInformacionEquivalenciaImporteApunte
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(2)]
        public Int32 CodigoDato;

        [FieldFixedLength(3)]
        public Int32 ClaveDivisaOrigenMovimiento;

        [FieldFixedLength(14)]
        public Decimal Importe;

        [FieldFixedLength(59)]
        public String Libre;


    }
}
