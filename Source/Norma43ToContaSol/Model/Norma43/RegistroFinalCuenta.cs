using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class RegistroFinalCuenta
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(4)]
        public Int32 ClaveEntidad;

        [FieldFixedLength(4)]
        public Int32 ClaveOficina;

        [FieldFixedLength(10)]
        public Decimal NumCuenta;

        [FieldFixedLength(5)]
        public Int32 NumApuntesDebe;

        [FieldFixedLength(14)]
        public Decimal TotalImportesDebe;

        [FieldFixedLength(1)]
        public Int32 NumApuntesHaber;

        [FieldFixedLength(14)]
        public Decimal TotalImportesHaber;

        [FieldFixedLength(4)]
        public Int32 CodigoSaldoFinal;

        [FieldFixedLength(14)]
        public Decimal SaldoFinal;

        [FieldFixedLength(3)]
        public Int32 ClaveDivisa;

        [FieldFixedLength(4)]
        public String Libre1;


    }
}
