import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Xadera on 4/3/2017.
 */
public class CompareCharArrays
{
    public static void main(String[] args)
    {
        Scanner inputA = new Scanner(System.in);
        Scanner inputB = new Scanner(System.in);

        String[] arrayA = inputA.nextLine().split("\\s+");
        String[] arrayB = inputB.nextLine().split("\\s+");

        String stringA = String.join("", arrayA);
        String stringB = String.join("", arrayB);

        String[] array = new String[]{stringA, stringB};
        Arrays.sort(array);

        System.out.println(array[0]);
        System.out.println(array[1]);
    }
}
