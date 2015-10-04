using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;


namespace Norma43ToContaSol.Model.Norma43
{
    [FixedLengthRecord(FixedMode.ExactLength)]
    public sealed class CabeceraDeCuenta
    {

        [FieldFixedLength(2)]
        public Int32 CodigoRegistro;

        [FieldFixedLength(4)]
        public Int32 ClaveEntidad;

        [FieldFixedLength(4)]
        public Int32 ClaveOficina;

        [FieldFixedLength(10)]
        public Decimal NumCuenta;

        [FieldFixedLength(6)]
        [FieldConverter(ConverterKind.Date, "yyMMdd")]
        public DateTime FechaInicial;

        [FieldFixedLength(6)]
        [FieldConverter(ConverterKind.Date, "yyMMdd")]
        public DateTime FechaFinal;

        [FieldFixedLength(1)]
        public Int32 ClaveDebeHaber;

        [FieldFixedLength(14)]
        public Decimal ImporteSaldoInicial;

        [FieldFixedLength(3)]
        public Int32 ClaveDivisa;

        [FieldFixedLength(1)]
        public Int32 ModalidadInformacion;

        [FieldFixedLength(26)]
        public String NombreAbreviado;

        [FieldFixedLength(3)]
        public String Libre1;


    }
}
