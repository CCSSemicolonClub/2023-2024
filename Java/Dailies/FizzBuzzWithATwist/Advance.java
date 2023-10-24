/*  
  Rules:
    No conditional statement (if, else, etc.)
    Any programming language is allowed to use
    
*/
public class Advance
{
	public static void main(String[] args) {
		for (int x = 1; x <= 100; x++) {
		    
		    String result = (x % 3 == 0 ? "Fizz" : "") + (x % 5 == 0 ? "Buzz" : "");
            System.out.println(result.isEmpty() ? x : result);
            
            /*
		      Check if x is divisible by 3 and, if so, add "Fizz" to the result.
            String result = (x % 3 == 0 ? "Fizz" : "") 
            
              Check if x is divisible by 5 and, if so, add "Buzz" to the result.
            + (x % 5 == 0 ? "Buzz" : "");
            
              If the result is still empty, it means x is not divisible by 3 or 5, so we use original number
            System.out.println(result.isEmpty() ? x : result);
            */
        }
	}
}
