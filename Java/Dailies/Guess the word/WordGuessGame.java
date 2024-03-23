import java.util.Random;
import java.util.Scanner;

public class WordGuessGame {
    public static void main(String[] args) {
        
        String[] words = {"apple", "banana", "cherry", "date", "elderberry", 
        "fig", "grape", "honeydew", "kiwi", "lemon", "mango", "orange", "pear", 
        "quince", "raspberry", "strawberry", "tangerine", "uva", "watermelon", "xylophone"};
        
        Random random = new Random();
        String chosenWord = words[random.nextInt(words.length)];
        int attempts = 5;

        System.out.println("Welcome to the Word Guess Game!");
        System.out.println("The word has " + chosenWord.length() + " letters.");

        Scanner scanner = new Scanner(System.in);

        while (attempts > 0) 
        {
            try{
                System.out.print("You have " + attempts + " attempts left. Enter your guess: ");
                String guess = scanner.next().toLowerCase();
                if(guess.length() > chosenWord.length()){
                    System.out.println("Length of input word exceeds");
                }
                else{
                    if (guess.equals(chosenWord)) {
                        System.out.println("Congratulations! You've guessed the word correctly.");
                        break;
                    } else {
                        attempts--;
                        System.out.println("Incorrect guess. Try again!");
        
                        // Check if each letter in the guess exists in the random word
                        char[] correctLetters = new char[guess.length()];
        
                        for (int i = 0; i < guess.length(); i++) {
                            char guessedLetter = guess.charAt(i);
                            char correctLetter = chosenWord.charAt(i);
        
                            if (guessedLetter == correctLetter) {
                                correctLetters[i] = guessedLetter;
                            } else if (chosenWord.contains(String.valueOf(guessedLetter))) {
                                correctLetters[i] = '(';
                            } else {
                                correctLetters[i] = '_';
                            }
                        }
        
                        System.out.print("Current progress: ");
                        for (int i = 0; i < correctLetters.length; i++) {
                            if (correctLetters[i] == '(') {
                                System.out.print("(" + guess.charAt(i) + " is in incorrect position) ");
                            } else {
                                System.out.print(correctLetters[i] + " ");
                            }
                        }
                        System.out.println();
                    }
                    if (attempts == 0) {
                        System.out.println("Sorry, you're out of attempts. The word was '" + chosenWord + "'.");
                    }
                }
            }
            catch(Exception e){
                System.out.println(e);
            }
        }
        
    }
}
