using System.ComponentModel;

namespace Pharma.API.Model
{
    public class UnitOfMeasurementModel
    {
        public int UnitOfMeasurementId { get; private set; }
        public UnitOfMeasurement Description { get; set; }
        private readonly List<ProductModel> _products = new List<ProductModel>();
        public IReadOnlyCollection<ProductModel> Products => _products;
    }
    public enum UnitOfMeasurement
    {
        [Description("AMPOLA")]
        AMP = 1,
        [Description("BILH�ES DE UNIDADES INTERNACIONAIS")]
        BUI = 2,
        [Description("BISNAGA")]
        BG = 3,
        [Description("BOLSA")]
        BOLS = 4,
        [Description("CAIXA")]
        CX = 5,
        [Description("CAPSULA")]
        CAP = 6,
        [Description("CARPULE")]
        CARP = 7,
        [Description("COMPRIMIDO")]
        COMP = 8,
        [Description("DOSE")]
        DOSE = 9,
        [Description("DR�GEA")]
        DRG = 10,
        [Description("ENVELOPE")]
        ENV = 11,
        [Description("FLACONETE")]
        FLAC = 12,
        [Description("FRASCO")]
        FR = 13,
        [Description("FRASCO AMPOLA")]
        FA = 14,
        [Description("GAL�O")]
        GAL = 15,
        [Description("GL�BULO")]
        GLOB = 16,
        [Description("GOTAS")]
        GTS = 17,
        [Description("GRAMA")]
        G = 18,
        [Description("LITRO")]
        L = 19,
        [Description("MICROGRAMAS")]
        MCG = 20,
        [Description("MILH�ES DE UNIDADES INTERNACIONAIS")]
        MUI = 21,
        [Description("MILIGRAMA")]
        MG = 22,
        [Description("MIL�LITRO")]
        ML = 23,
        [Description("�VULO")]
        OVL = 24,
        [Description("PASTILHA")]
        PAS = 25,
        [Description("LATA")]
        LT = 26,
        [Description("P�ROLA")]
        PER = 27,
        [Description("P�LULA")]
        PIL = 28,
        [Description("POTE")]
        PT = 29,
        [Description("QUILOGRAMA")]
        KG = 30,
        [Description("SERINGA")]
        SER = 31,
        [Description("SUPOSIT�RIO")]
        SUP = 32,
        [Description("TABLETE")]
        TABLE = 33,
        [Description("TUBETE")]
        TUB = 34,
        [Description("TUBO")]
        TB = 35,
        [Description("UNIDADE")]
        UN = 36,
        [Description("UNIDADE INTERNACIONAL")]
        UI = 37,
        [Description("CENT�METRO")]
        CM = 38,
        [Description("CONJUNTO")]
        CONJ = 39,
        [Description("KIT")]
        KIT = 40,
        [Description("METRO")]
        M = 41,
        [Description("PACOTE")]
        PC = 42,
        [Description("ROLO")]
        RL = 43,
        [Description("GRAY")]
        GY = 44,
        [Description("CENTGRAY")]
        CGY = 45,
        [Description("PAR")]
        PAR = 46,
        [Description("ADESIVO TRANSD�RMICO")]
        ADES = 47,
        [Description("EFEV COMPRIMIDO EFERVECENTE")]
        COE = 48,
        [Description("MST COMPRIMIDO MASTIG�VEL")]
        COM = 49,
        [Description("SACHE")]
        SACHE = 50,
        [Description("MILILITROS")]
        MM = 51,
        [Description("GOTA")]
        GT = 52,
        [Description("CARTELA")]
        CARY = 53,
        [Description("BLOCO")]
        BLC = 54,
        [Description("POMADA")]
        POM = 55
    }
}

// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('AMPOLA');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('BILH�ES DE UNIDADES INTERNACIONAIS');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('BISNAGA');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('BOLSA');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('CAIXA');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('CAPSULA');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('CARPULE');
//
// INSERT INTO public."UnitOfMeasurement"
//     ("Description")
// VALUES('COMPRIMIDO');