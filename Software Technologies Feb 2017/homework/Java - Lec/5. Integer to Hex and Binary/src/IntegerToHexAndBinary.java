import java.util.Scanner;

/**
 * Created by Xadera on 4/3/2017.
 */
public class IntegerToHexAndBinary {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int number = scanner.nextInt();

        String hex = Integer.toHexString(number);
        String binary = Integer.toBinaryString(number);

        System.out.println(hex.toUpperCase());
        System.out.println(binary);
    }
}
