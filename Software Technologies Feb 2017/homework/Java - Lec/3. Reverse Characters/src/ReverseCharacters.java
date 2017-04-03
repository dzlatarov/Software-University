import java.util.Scanner;

public class ReverseCharacters
{
    public static void main(String[] args)
    {
        String[] stringArray = new String[3];
        for(int i = 2; i >= 0; i--)
        {
            Scanner scanner = new Scanner(System.in);

            String string = scanner.nextLine();

            stringArray[i] = string;
        }

        System.out.println(String.join("", stringArray));
    }
}
