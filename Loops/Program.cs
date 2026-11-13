

/*for (int i = 0; i < transactions.Length; i++)
{
    Console.WriteLine($"Transaction {i + 1}: R{transactions[i]:F2}");
}

decimal total = 0;
foreach (var transaction in transactions)
{
    total = total + transaction;
}
Console.WriteLine($"Total: R{total:F2}");

int transactionCount = 0;
foreach (var transaction in transactions)
{
    if (transaction > 200.00m)
    {
        transactionCount++;
    }
}
Console.WriteLine($"Transactions over R200.00: {transactionCount}");

decimal savings = 0;
int months = 0;
while (savings < 5000.00m)
{
    savings += 750.00m;
    months++;
}
Console.WriteLine($"It takes {months} months to save {savings:F2}");*/

using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

decimal[] transactions = { 250.00m, 45.50m, 1200.00m, 89.99m, 310.75m, 15.00m };

PrintTransactions(transactions);

decimal total = CalculateTotal(transactions);
Console.WriteLine($"Total: R{total:F2}");

int transactionCount1 = CountOver(transactions, 200.00m);
Console.WriteLine($"Transactions over R200.00: {transactionCount1}");

int transactionCount2 = CountOver(transactions, 1000.00m);
Console.WriteLine($"Transactions over R1000.00: {transactionCount2}");

int months = MonthsToSave(6000.00m, 800.00m);
Console.WriteLine($"It takes {months} months to save R6000.00");

void PrintTransactions(decimal[] amounts)
{
    for(int i = 0; i < amounts.Length; i++)
    {
        Console.WriteLine($"Transaction {i + 1}: R{amounts[i]:F2}");
    }
}

decimal CalculateTotal(decimal[] amounts)
{
    decimal total = 0;
    foreach (var amount in amounts)
    {
        total += amount;
    }
    return total;
}

int CountOver(decimal[] amounts, decimal limit)
{
    int count = 0;
    foreach (var amount in amounts)
    {
        if (amount > limit)
        {
            count++;
        }
    }
    return count;
}

int MonthsToSave(decimal goal, decimal monthlySaving)
{
    decimal savings = 0;
    int months = 0;
    while (savings < goal)
    {
        savings += monthlySaving;
        months++;
    }
    return months;
}