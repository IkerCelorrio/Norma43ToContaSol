using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class PrincipalDeMovimiento
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(4)]
        public String Libre;

        [FieldFixedLength(4)]
        public Int32 ClaveOficinaOrigen;

        [FieldFixedLength(6)]
        [FieldConverter(ConverterKind.Date, "yyMMdd")]
        public DateTime FechaOperacion;

        [FieldFixedLength(6)]
        [FieldConverter(ConverterKind.Date, "yyMMdd")]
        public DateTime FechaValor;

        [FieldFixedLength(2)]
        public Int32 ConceptoComun;

        [FieldFixedLength(3)]
        public Int32 ConceptoPropio;

        [FieldFixedLength(1)]
        public Int32 ClaveDebeHaber;

        [FieldFixedLength(14)]
        public Decimal Importe;

        [FieldFixedLength(10)]
        public Int32 NumDocumento;

        [FieldFixedLength(12)]
        public Int32 Referencia1;

        [FieldFixedLength(16)]
        public String Referencia2;

    }
}
