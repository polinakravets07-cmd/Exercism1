public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string digits = new string(phoneNumber.Where(char.IsDigit).ToArray());

        if (digits.Length == 11 && digits[0] == '1')
        {
            digits = digits.Substring(1);
        }

        if (digits.Length != 10)
        {
            throw new ArgumentException("Invalid phone number.");
        }

        if (digits[0] < '2' || digits[3] < '2')
        {
            throw new ArgumentException("Invalid phone number.");
        }

        return digits;
    }
}