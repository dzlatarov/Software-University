import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class FitStringIn20Chars
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        if(input.length() < 20)
        {
            String result = "";
            for(int i = input.length(); i < 20; i++)
            {
                result += "*";
            }

            System.out.println(input + result);
        }
        else
        {
            System.out.println(input.substring(0, 20));
        }
    }
}
