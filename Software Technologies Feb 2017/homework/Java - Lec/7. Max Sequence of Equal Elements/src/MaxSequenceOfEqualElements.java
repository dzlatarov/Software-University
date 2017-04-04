import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

/**
 * Created by Xadera on 4/3/2017.
 */
public class MaxSequenceOfEqualElements
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

       int position = 0;
       int length = 1;
       Map<Integer, Integer> kPositionVLength = new HashMap<Integer, Integer>();
       for(int i = 0; i < inputSize - 1; i++)
       {
           int a = integerArray[i];
           int b = integerArray[i + 1];

           if(i == inputSize - 2)
           {
                if(a == b)
                {
                    length++;
                    kPositionVLength.put(position, length);
                }
                else
                {
                    kPositionVLength.put(position, length);
                }
           }
           else if (a == b)
           {
               length++;
           }
           else
           {
                   kPositionVLength.put(position, length);
                   position = i + 1;
                   length = 1;
           }
       }
        int bestPosition = 0;
        int bestLength = 0;
        for (Map.Entry<Integer,Integer> entry : kPositionVLength.entrySet())
        {
            int kPosition = entry.getKey();
            int vLength = entry.getValue();

            if(vLength > bestLength)
            {
                bestPosition = kPosition;
                bestLength = vLength;
            }

        }

        for(int i = bestPosition; i < bestPosition + bestLength; i++)
        {
            System.out.print(integerArray[i] + " ");
        }
    }
}
