import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class EqualSums
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        String[] inputToArray = input.split("\\s+");
        int inputSize = inputToArray.length;

        int[] integerArray = new int[inputSize];

        for(int i = 0; i < inputSize; i++)
        {
            integerArray[i] = Integer.parseInt(inputToArray[i]);
        }

        Boolean sumExist= false;
        for(int i = 0; i < inputSize; i++)
        {
            if(LeftSum(integerArray, i) == RightSum(integerArray, i))
            {
                System.out.println(i);
                sumExist = true;

                break;
            }
        }

        if(!sumExist)
        {
            System.out.println("no");
        }
    }

    public static int LeftSum(int[] ints, int position)
    {
        int sum = 0;
        for(int i = 0; i < position; i++)
        {
            sum += ints[i];
        }

        return sum;
    }

    public static int RightSum(int[] ints, int position)
    {
        int sum = 0;
        for(int i = position + 1; i < ints.length; i++)
        {
            sum += ints[i];
        }

        return sum;
    }
}
