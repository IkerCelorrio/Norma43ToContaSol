using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class ComplementariosConcepto
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(2)]
        public Int32 CodigoDato;

        [FieldFixedLength(38)]
        public Int32 Concepto1;

        [FieldFixedLength(38)]
        public Int32 Concepto2;


    }
}
