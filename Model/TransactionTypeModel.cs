namespace Pharma.API.Model
{
    public class TransactionTypeModel
    {
        public int TransactionTypeId { get; private set; }
        public TransactionType Description { get; set; }
        private readonly List<StockTransactionModel> _stockTransactions = new List<StockTransactionModel>();
        public IReadOnlyCollection<StockTransactionModel> StockTransactions => _stockTransactions;
    }

    public enum TransactionType
    {
        EntradaEstoque = 1,
        EntradaPorDevolucao = 2,
        SaidaEstoque = 3, 
        SaidaPorPedidoDeProduto = 4,
    }
}

// INSERT INTO public."TransactionType"
//     ("Description")
// VALUES('EntradaEstoque');
//
// INSERT INTO public."TransactionType"
//     ("Description")
// VALUES('EntradaPorDevolucao');
//
// INSERT INTO public."TransactionType"
//     ("Description")
// VALUES('SaidaEstoque');
//
// INSERT INTO public."TransactionType"
//     ("Description")
// VALUES('SaidaPorPedidoDeProduto');