namespace ExpenseApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TransactionsList.ItemsSource = transactions;
        }

        private List<Transaction> transactions = new()
        {
            new Transaction
            {
                Description = "Salary",
                Amount = 39000,
                Category = "Income"
            },
            new Transaction
            {
                Description = "Rent",
                Amount = -6125,
                Category = "Housing"
            },
            new Transaction
            {
                Description = "Swiggy",
                Amount = -250,
                Category = "Food"
            }
        };

    }    
}
