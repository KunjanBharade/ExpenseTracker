namespace ExpenseApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //var path = @"C:\Users\KBharade\LearnAndBuild\ExpenseTracker_LAB\ExpenseApp\ExpenseApp\Samples\sample_statement.csv";

            //var lines = File.ReadAllLines(path);

            //foreach (var line in lines.Skip(1))
            //{
            //    var parts = line.Split(',');

            //    System.Diagnostics.Debug.WriteLine(
            //        $"Date: {parts[0]}, Description: {parts[1]}, Amount: {parts[2]}");
            //}

            var transactions = new List<Transaction>
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

            foreach (var transaction in transactions)
            {
                System.Diagnostics.Debug.WriteLine(
                    $"{transaction.Description} : {transaction.Amount}");
            }
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
