# FizzBuzzBang Program

## Purpose: Program takes in any number 1 - 100 (either through user input or a for loop) and prints the number according to a set of rules:

Fizz - if a number contains a 3 or is divisible by 3
Buzz - if a number contains a 5 or is divisible by 5
Bang - if a number contains a 7 or is divisible by 7
If a number does not meet any of the previous conditions, it remains unchanged/

The logic for the program is as follows:

Helper methods:
- Three main methods: TranslateNumber, DoesContainDigit, and IsDivisibleByNumber
- IsDivisibleByNumber takes as arguments the Number as a string and an integer number to test
	- The Number is checked for divisibility by integer
	- If Number is divisible by Integer, method returns true. Otherwise, returns false.
- DoesContainDigit takes as an argument the Number as a string and checks for a request Digit that is also a string.
	- The method iterates through each digit in the Number.
	- If requested Digit is found, method returns true and stops the loop. Otherwise, returns false.
	
Logic:
- Number is input as a string from console
- TranslateNumber takes as an argument the Number as a string and Number Translated, which is initialized as an empty string and will hold the Number after it has been processed.
- Number is converted into an Integer as a separate variable
- The string version of Number runs through DoesContainDigit to check if a "3" can be found in the number.
- The integer version of Number runs through DivisbleByNumber to check if it is divisible by 3.
- If either of these conditions are true, "fizz" is added to the Number Translated string.
- The next two steps are followed for 5 (adding "buzz") and 7 (adding "bang"
- If at the end the Number doesn't meet any of the previous conditions and the Number Translated string remains empty, Number Translated is set to the value of the original Number from user.
- TranslateNumber returns Number Translated, which is then printed to Console.
