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
        [Description("BILHÕES DE UNIDADES INTERNACIONAIS")]
        BUI = 2,
        [Description("BISNAGA")]
        BG = 3,
        [Description("BOLSA")]
        BOLS = 4,
        [Description("CAIXA")]
        CX = 5,
        [Description("CÁPSULA")]
        CAP = 6,
        [Description("CARPULE")]
        CARP = 7,
        [Description("COMPRIMIDO")]
        COP = 8,
        [Description("DOSE")]
        DOSE = 9,
        [Description("DRÁGEA")]
        DRG = 10,
        [Description("ENVELOPE")]
        ENV = 11,
        [Description("FLACONETE")]
        FLAC = 12,
        [Description("FRASCO")]
        FR = 13,
        [Description("FRASCO AMPOLA")]
        FA = 14,
        [Description("GALÃO")]
        GAL = 15,
        [Description("GLÓBULO")]
        GLOB = 16,
        [Description("GOTAS")]
        GTS = 17,
        [Description("GRAMA")]
        G = 18,
        [Description("LITRO")]
        L = 19,
        [Description("MICROGRAMAS")]
        MCG = 20,
        [Description("MILHÕES DE UNIDADES INTERNACIONAIS")]
        MUI = 21,
        [Description("MILIGRAMA")]
        MG = 22,
        [Description("MILÍLITRO")]
        ML = 23,
        [Description("ÓVULO")]
        OVL = 24,
        [Description("PASTILHA")]
        PAS = 25,
        [Description("LATA")]
        LT = 26,
        [Description("PÉROLA")]
        PER = 27,
        [Description("PÍLULA")]
        PIL = 28,
        [Description("POTE")]
        PT = 29,
        [Description("QUILOGRAMA")]
        KG = 30,
        [Description("SERINGA")]
        SER = 31,
        [Description("SUPOSITÓRIO")]
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
        [Description("CENTÍMETRO")]
        CM = 38,
        [Description("CONJUNTO")]
        CONJ = 39,
        [Description("KIT")]
        KIT = 40,
        [Description("MAÇO")]
        MÇ = 41,
        [Description("METRO")]
        M = 42,
        [Description("PACOTE")]
        PC = 43,
        [Description("PEÇA")]
        PÇ = 44,
        [Description("ROLO")]
        RL = 45,
        [Description("GRAY")]
        GY = 46,
        [Description("CENTGRAY")]
        CGY = 47,
        [Description("PAR")]
        PAR = 48,
        [Description("ADESIVO TRANSDÉRMICO")]
        ADES = 49,
        [Description("EFEV COMPRIMIDO EFERVECENTE")]
        COE = 50,
        [Description("MST COMPRIMIDO MASTIGÁVEL")]
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