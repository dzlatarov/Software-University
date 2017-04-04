import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class CensorEmailAddress
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String[] emailSplit = input.split("@");

        scan = new Scanner(System.in);
        input = scan.nextLine();

        String starinator = "";
        for(int i = 0; i < emailSplit[0].length(); i++)
        {
            starinator += "*";
        }
        String result = input.replaceAll(emailSplit[0], starinator);

        System.out.println(result);
    }
}
