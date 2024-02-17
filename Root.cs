namespace Lab3Lib;

public class Root
{
    public static int findMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    public static int findMax(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            return num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }
}
