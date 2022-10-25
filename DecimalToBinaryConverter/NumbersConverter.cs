namespace DecimalToBinaryConverter;

internal static class NumbersConverter
{
    internal static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binaryNumber = string.Empty;

        // Пока у числа есть остаток - это значит, что мы можем переводить его в двоичное число
        while (decimalNumber > 0)
        {
            // Получаем остаток от деления, что б понимать, что чисто делится на 2 или нет
            // Если число делится на 2 без остатка - то reminder будет 0. Напрмиер, 8 % 2 = 0
            // Если число НЕ делится на 2 без остатка - то reminder будет 1. Напрмиер, 9 % 2 = 1
            int remainder = decimalNumber % 2;

            // Добавляем результат деления в текущую переменную binaryNumber (в начало)
            // Например, 1 + "101" = "1101"
            binaryNumber = remainder + binaryNumber;

            // Делим десятичное число на 2 и продолжаем перевод уже с новым значением
            decimalNumber = decimalNumber / 2;
        }

        return binaryNumber;
    }
}