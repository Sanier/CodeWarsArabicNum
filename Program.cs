Solution(39);

static string Solution(int n)
{
    int[] arabic = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    int i = 0;
    string result = "";
    bool fl = false;

    for (int l = 0; l < arabic.Length; l++)
        if (n + 1 == arabic[l] && n != 39)
        {
            fl = true;
            result = "I" + roman[l];
        }

    if (!fl)
    {
        for (int l = 0; l < arabic.Length; l++)
            if (arabic[l] == n)
            {
                fl = true;
                result = roman[l];
            }
    }

    if (!fl)
    {
        for (int j = 0; j < arabic.Length; j++)
        {
            for (int k = j + 1; k < arabic.Length; k++)
            {
                if ((n == arabic[j] - arabic[k]) && (((arabic[j] - arabic[k]) % 10 == 0) || (arabic[j] - arabic[k]) % 5 == 0))
                {
                    result = roman[k] + roman[j];
                    fl = true;
                }
                if (fl) break;
            }
            if (fl) break;
        }
    }
    if (fl == false)
    {
        while (n > 0)
        {
            if (arabic[i] <= n)
            {
                n = n - arabic[i];
                result += roman[i];
            }
            else i++;
        }
    }
    Console.WriteLine(result);
    return result;
}
    
