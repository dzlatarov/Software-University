import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Xadera on 4/3/2017.
 */
public class VowelsOrDigit
{
    public static void main(String[] args)
    {
        String[] digits = new String[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        String[] vowels = new String[] {"a", "A", "e", "E", "i", "I", "o", "O", "u", "U"};

        Scanner scanner = new Scanner(System.in);
        String character = scanner.nextLine();

        if(Arrays.asList(digits).contains(character))
        {
            System.out.println("digit");
        }
        else if(Arrays.asList(vowels).contains(character))
        {
            System.out.println("vowel");
        }
        else
        {
            System.out.println("other");
        }
    }
}
