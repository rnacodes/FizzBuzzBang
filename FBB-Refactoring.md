# FizzBuzzBang Refactoring

* Renamed variables to prevent confusion
* Dialogue needs to use while loops for ease of use and try/catch loops to check for invalid input
* In its current form, the Translator needs to be instantiated for each number. I am changing this so that the Translator can be instantiated without any arguments. This is important due to the method that prints out all numbers 1 to 1000 to console. Previously, this would have been unfeasible due to needing to create a new instantion of a Translator each time. 
* ## Class improvements

* The way that the class was built previously, it could just be e method.
* Remove constructor that contains initialized copies of the user number.
* Now only convert number to Int as needed so that there aren't Text/Int copies floating around.
* Similar to the aboved, removed constructor that contained initialized copies of the user number