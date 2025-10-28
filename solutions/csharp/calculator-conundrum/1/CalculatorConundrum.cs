public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        
        if(operation is null)
            throw new ArgumentNullException();
        if(string.IsNullOrWhiteSpace(operation))
            throw new ArgumentException();
        if(operation != "+" && operation != "*" && operation != "/")
            throw new ArgumentOutOfRangeException();
        
        switch (operation)
        {
            case "+": 
                return $"{operand1} {operation} {operand2} = {(operand1 + operand2).ToString()}" ;
            case "*": 
                return $"{operand1} {operation} {operand2} = {(operand1 * operand2).ToString()}" ;
            case "/": 
                {
                    if(operand2 == 0)
                        return  "Division by zero is not allowed.";
                  return $"{operand1} {operation} {operand2} = {(operand1 / operand2).ToString()}" ;
                }
            default : return string.Empty;
        }
    }
}
