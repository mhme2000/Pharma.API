namespace Pharma.API.Model
{
    public class TransactionStatusModel
    {
        public int TransactionStatusId { get; private set; }
        public TransactionStatus Description { get; set; }
        private readonly List<StockTransactionModel> _stockTransactions = new List<StockTransactionModel>();
        public IReadOnlyCollection<StockTransactionModel> StockTransactions => _stockTransactions;
    }

    public enum TransactionStatus
    {
        Aberto = 1,
        AguardandoSeparacao = 2,
        EmSeparacao = 3,
        EmEntrega = 4,
        Finalizado = 5,
        Devolvido = 6,
        Cancelado = 7,
    }
}

// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('Aberto');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('AguardandoSeparacao');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('EmSeparacao');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('EmEntrega');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('Finalizado');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('Devolvido');
//
// INSERT INTO public."TransactionStatus"
//     ("Description")
// VALUES('Cancelado');