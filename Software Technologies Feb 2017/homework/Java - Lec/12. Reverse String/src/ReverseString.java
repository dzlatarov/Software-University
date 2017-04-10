import java.util.Scanner;

/**
 * Created by Xadera on 4/4/2017.
 */
public class ReverseString {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        StringBuilder chars = new StringBuilder();
        for(int i = 2; i >= 0; i--)
        {
            chars.append(scanner.next());
        }

        System.out.println(chars.reverse());
    }
}
