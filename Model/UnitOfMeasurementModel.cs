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
        [Description("C�PSULA")]
        CAP = 6,
        [Description("CARPULE")]
        CARP = 7,
        [Description("COMPRIMIDO")]
        COP = 8,
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
        [Description("MA�O")]
        M� = 41,
        [Description("METRO")]
        M = 42,
        [Description("PACOTE")]
        PC = 43,
        [Description("PE�A")]
        P� = 44,
        [Description("ROLO")]
        RL = 45,
        [Description("GRAY")]
        GY = 46,
        [Description("CENTGRAY")]
        CGY = 47,
        [Description("PAR")]
        PAR = 48,
        [Description("ADESIVO TRANSD�RMICO")]
        ADES = 49,
        [Description("EFEV COMPRIMIDO EFERVECENTE")]
        COE = 50,
        [Description("MST COMPRIMIDO MASTIG�VEL")]
        COM = 51,
        [Description("SACHE")]
        SACHE = 52,
        [Description("MILILITROS")]
        MM = 53,
        [Description("GOTA")]
        GT = 54,
        [Description("CARTELA")]
        CARY = 55,
        [Description("BLOCO")]
        BLC = 56,
        [Description("POMADA")]
        POM = 57           
    }
}