using System.Collections;
using System.Numerics;

namespace StringMultiply;
public class Class1
{
    public string Multiply(string num1, string num2)
    {
        Hashtable nums = new Hashtable();
        nums.Add('0', 0);
        nums.Add('1', 1);
        nums.Add('2', 2);
        nums.Add('3', 3);
        nums.Add('4', 4);
        nums.Add('5', 5);
        nums.Add('6', 6);
        nums.Add('7', 7);
        nums.Add('8', 8);
        nums.Add('9', 9);
        BigInteger numberOne = 0;
        BigInteger numberTwo = 0;
        BigInteger digitNum = 1;
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            numberOne += (int)nums[num1[i]] * digitNum;
            digitNum *= 10;
        }
        digitNum = 1;
        for (int i = num2.Length - 1; i >= 0; i--)
        {
            numberTwo += (int)nums[num2[i]] * digitNum;
            digitNum *= 10;
        }

        BigInteger sum = numberOne * numberTwo;

        return sum.ToString();
    }
}
