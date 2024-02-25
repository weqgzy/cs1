Console.WriteLine("ent: ");
string enter_str = Console.ReadLine();
char [] expresion = enter_str.ToCharArray();

if (expresion.Length == 3)
{
    int result = 0;
    bool flag = false;
    int operand_1 = Convert.ToInt16(expresion[0].ToString());
    char operation = expresion[1];
    int operand_2 = Convert.ToInt16(expresion[2].ToString());

    switch (operation)
    {
        case '-':
            result = operand_1 - operand_2;
            flag = true;
            break;

        case '+':
            result = operand_1 + operand_2;
            flag = true;
            break;

        case '/':
            result = operand_1 / operand_2;
            flag = true;
            break;

        case '*':
            result = operand_1 * operand_2;
            flag = true;
            break;

        default:
            Console.WriteLine("Wrong expresion:" + " " + operation + ". " + "Try again!");
            break;
    }
    if (flag) 
    {
        Console.WriteLine(operand_1 + " " + operation + " " + operand_2 + " =" + " " + result);
    } 
}