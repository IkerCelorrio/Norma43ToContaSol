using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class FinDeFichero
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(18)]
        public Decimal Nueves;

        [FieldFixedLength(6)]
        public Int32 NumRegistros;

        [FieldFixedLength(54)]
        public String Libre;


    }
}
