/*
Create a FizzBuzz program, which will print
  “Fizz” if the number is divisible by 3
  “Buzz” if the number is divisible by 5
  “FizzBuzz” if the number is divisible by 3 and 5
  A number if none of the above
  Make it up to 100
*/
public class Basic
{
    public static void main(String[] args) {
        for (int x = 1; x <= 100; x++) {
            String res = "";

            // Check if x is divisible by 3 and append "Fizz" if true
            if (x % 3 == 0) {
                res += "Fizz";
            }

            // Check if x is divisible by 5 and append "Buzz" if true
            if (x % 5 == 0) {
                res += "Buzz";
            }

            // If res is empty, print the number; otherwise, print res
            System.out.println(res.length() == 0 ? x : res);
        }
    }
}
