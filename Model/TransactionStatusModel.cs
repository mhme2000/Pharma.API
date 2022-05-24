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
        Aguardando = 2,
        EmEntrega = 3,
        Recebido = 4,
        Cancelado = 5,
        Devolvido = 6,
    }
}