import java.util.Scanner;

/**
 * Created by Xadera on 4/3/2017.
 */
public class BooleanVariable
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        Boolean result = scan.nextBoolean();

        if(result)
        {
            System.out.println("Yes");
        }
        else
        {
            System.out.println("No");
        }
    }
}
