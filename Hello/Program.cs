const decimal MonthlyBudget = 2500.00m;
string category = "Groceries";
decimal amountSpent = 2400.00m;
var transactionsCount = 12;
var remainingBudget = MonthlyBudget - amountSpent;
bool isOverBudget = remainingBudget < 0;



/*Console.WriteLine($"Category: {category}");
Console.WriteLine($"Transactions: {transactionsCount}");
Console.WriteLine($"Spent: R{amountSpent:F2} of R{MonthlyBudget:F2} budget");  
Console.WriteLine($"Remaining: R{remainingBudget:F2}");
Console.WriteLine($"Over budget: {isOverBudget}"); 
Console.WriteLine($"Note: {note}");*/

var percentageUsed = (amountSpent / MonthlyBudget) * 100;
Console.WriteLine($"Used: {percentageUsed:F1}% of budget");

// if/else statements
if (percentageUsed > 100)
{
    Console.WriteLine($"Status: Over budget, stop spending");
}
else if (percentageUsed >= 90)
{
    Console.WriteLine($"Status: Careful, almost at your limit");
}
else if (percentageUsed >= 50)
{
    Console.WriteLine($"Status: On track");
}
else
{
    Console.WriteLine($"Status: Plenty of budget left");
}

//Swtch statements
string statusMessage = percentageUsed switch
{
    > 100 => "Over budget, stop spending",
    >= 90 => "Careful, almost at your limit",
    >= 50 => "On track",
    _ => "Plenty of budget left"
};
Console.WriteLine($"Status: {statusMessage}");

string? note = null;
Console.WriteLine($"Note: {note ?? "No note added"}");
