import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class MostFrequentNumber
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

        int result = getPopularElement(integerArray);

        System.out.println(result);
    }

    public static int getPopularElement(int[] a)
    {
        int count = 1, tempCount;
        int popular = a[0];
        int temp = 0;
        for (int i = 0; i < (a.length - 1); i++)
        {
            temp = a[i];
            tempCount = 0;
            for (int j = 1; j < a.length; j++)
            {
                if (temp == a[j])
                    tempCount++;
            }
            if (tempCount > count)
            {
                popular = temp;
                count = tempCount;
            }
        }
        return popular;
    }
}
