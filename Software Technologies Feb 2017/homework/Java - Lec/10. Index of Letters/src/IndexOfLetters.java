import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class IndexOfLetters
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        for(int i = 0; i < input.length(); i++)
        {
            System.out.println(input.toCharArray()[i] + " -> " + (input.toCharArray()[i] - 97));
        }
    }
}
