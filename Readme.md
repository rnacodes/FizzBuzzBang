# FizzBuzzBang Program

##Purpose: Program takes in any number 1 - 100 (either through user input or a for loop) and prints the number according to a set of rules:

Fizz - if a number contains a 3 or is divisible by 3
Buzz - if a number contains a 5 or is divisible by 6
Bang - if a number contains a 7 or is divisible by 7

The logic for the program is as follow:

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
- TranslateNumber takes as an argument the Number as a string and Number Translated, which is initialized as an empty string.
