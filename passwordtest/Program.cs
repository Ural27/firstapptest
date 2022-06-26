
    while (true)
    {
        string password = Console.ReadLine();
        Console.WriteLine(CheckPassword(password));
    }


static bool CheckPassword(string password)
{
    char[] symbols = "!@#$%^&**()_".ToCharArray();
    bool correctPassword = true;
    int a = 'a';
    int z = 'z';
    int A = 'A';
    int Z = 'Z';
    if (password.Length < 8 && password.Length > 20)
    {
        correctPassword = false;
        PrintError("Длина пароля должна быть от 8 до 20 символов");
    }
     if (!password.Any(char.IsDigit))
    {
        correctPassword = false;
        PrintError("Должно быть наличие цифр");
    }
     if (password.IndexOfAny(symbols) == -1)
    {
        correctPassword = false;
        PrintError("Должны быть специальные символы");
    }
     if (!password.Any(char.IsUpper))
    {
        correctPassword = false;
        PrintError("Должны быть буквы в верхнем регистре");
    }
     if (!password.Any(char.IsLower))
    {
        correctPassword = false;
        PrintError("Должны быть буквы в нижнем регистре");
    }
    //foreach(char c in password)
    //{
    // int codeCurrentSymbol = c;
    // if (!char.IsDigit(c) && !symbols.Contains(c) &&
    // !(codeCurrentSymbol >a && codeCurrentSymbol < z || codeCurrentSymbol > A && codeCurrentSymbol < Z))
    // {
    // correctPassword = false;
    // }
    //}
    return correctPassword;
}

static void PrintError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}