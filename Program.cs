// Bring in the Billing namespace
using Billing;

// Set up the order
double subtotal = 49.99;

// Calculate tax and total
double tax = Calculator.CalculateTax(subtotal);
double total = Calculator.CalculateTotal(subtotal, tax);
// Print the receipt
 Console.WriteLine($"Subtotal: {subtotal:C}");
 Console.WriteLine($"Tax:      {tax:C}");
 Console.WriteLine($"Total:    {total:C}");

  double outOfStateSubtotal = 80.00;
 double outOfStateTax = Calculator.CalculateTax(outOfStateSubtotal, taxRate: 0.05);
 double outOfStateTotal = Calculator.CalculateTotal(outOfStateSubtotal, outOfStateTax);

 Console.WriteLine($"\nOut-of-state subtotal: {outOfStateSubtotal:C}");
 Console.WriteLine($"Out-of-state tax:      {outOfStateTax:C}");
 Console.WriteLine($"Out-of-state total:    {outOfStateTotal:C}");