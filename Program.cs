/*
* Author: Daniela Lopez
* Course: COMP-003A-L01
* Purpose: Lecture activity for variables, type system, math, and console properties
* Reference: The C# Player's Guide (4e) by RB Whitaker
*/


namespace COMP003A.LectureActivity2
{
internal class program
{
static void main (string[] args)
{
/* working with variables */
// the following code shows all three primary variable-related activities:
string username; // declaring a variable (1 of 3)
console.writeline ("What is your name?"); // request for user input
username = console.readline (); // assigning a value to a variable (2 of 3)
console.writeline ("Hi" + username); // retrieving its current value (3 of 3)


// another example of the three primary variable related activities
(declaring, assigning, and retrieving)
string favoritecolor;
console.writeline ("What is your favorite color?");
favoritecolor = console.readline ();
console.writeline ("Your favorite coloe is" + favoritecolor);


/* working with varible integers */
int score; // declare a new varibale with a data type int
// score = "Generic User"; // will fail to compile because you are assigning a string value to an integer variable
// score = "0"; // will still fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
score = 0; // works
score = 4; // you can also reassign values as long as they are within scope and not constant
score = 11;
score = -1564;


/* reading from a variable does not change it */
int a;
int b;


a = 5;
b = 2;
console.writeline ("The current value of a: " + a);
console.writeline ("The current value of b: " + b);


b = a;
a = -3;
console.writeline ("The new value of a: " + a);
console.writeline ("The new value of b: " + b);


/* variables are case-sensitive */
// the variables below are different despite having similar names
string exampleVariable;
string exampleVAriable;
string exampleVARiable;


console.writeline ("*****");
/*
* types of variables and values matter in C#. they aare not interchangeable.
* there are eight integer types for storing integers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
* the char type stores single characters.
* the string type stores longer text.
* there are three types for storing real numbers: float, double, and decimal.
* the bool type stores truth values (true and false) used in logic.
* these types are the building blocks of a much larger type system.
* using var for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (but it still has a specific type.)
* the System.Convert class is a useful class to convert from one type to another.
*/


/* declaring and using variable with integer types */
byte aSingleByte = 34;
console.writeline ("aSingleByte: " + aSingleByte);
aSingleByte = 17;
console.writeline ("aSingleByte: " + aSingleByte);


short aNumber = 5039;
console.writeline ("aNumber: " + aNumber);
aNumber = -4354;
console.writeline ("aNumber: " + aNumber);


long aVeryBigNumber = 395904282569;
console.writeline ("aVeryBigNumber: " + aVeryBigNumber);
aVeryBigNumber = 13;
console.writeline ("aVeryBigNumber: " + aVeryBigNumber);


int anInteger = 2147483647


/* declaring, usiing, and concatenating characters and strings */
char aLetter = 'A'; // character values are enclosed in single quotes
string message = "Hello World!"; // string values are enclosed in double quotes


console.writeline ("Concatenation using + : " + aLetter + " " + message); // use the plus (+) sign in between characters/strings to concatenate
console.writeline ($"Concatenation using string interpolation : {aLetter} {message} "); // use string  interpolation with a dollar-sign ($) before the opening double-quote and enclosing variable with curly braces ({variableName})


/* floating-point types */
double number1 = 3.5623;
float number2 = 3.5623f;
decimal number3 = 3.5623m;
console.writeline ($"Value of number1: {number1} ");
console.writeline ($"Value of number2: {number2} ");
console.writeline ($"Value of number3: {number3} ");


/* scientific notation */
double avogadrosNumber = 6.022e23;
console.writeline ($"Value of avogadorsNumber: {avogadrosNumber} ");


/* bool type */
bool itWorked = true;
console.writeline ($"Value of itWorked: {itWorked} ");
itWorked = false;
console.writeline ($"New value of itWorked: {itWorked} ");


/* convert */
string inputAgeString;
int inputAge;
int currentYear = 2023;
console.writeline ($"Enter age in {currentYear} : ");
inputAgeString = console.readline ();
inputAge = Convert.ToInt32 (inputAgeString);
console.writeline ($"Your age is {inputAge} ");


console.writeline ("*****");
/*
* math operations
* addition: +
* subtraction: -
* multiplication: *
* division: /
* modulo: % (remainder)
*/


int addition = 2 + 3;
int subtraction = 5 - 2;
int multiplication = 22 * 2;
int division = 21 / 7;
int modulo = 77 % 5;
console.writeline ($"Value of addition: {addition} ");
console.writeline ($"Value of subtraction: {subtraction} ");
console.writeline ($"Value of multiplication: {multiplication} ");
console.writeline ($"Value of division: {division} ");
console.writeline ($"Value of modulo: {modulo} ");


/*
* arithmetic, compound expressions and order of operations
* multiplication and division are done first, left to right
* addition and subtraction are done last, left to right
* reference: https://csharpplayersguide.com/articles/operators-table
*/


int arithmetic1; // declaring the variable arithmetic1.
arithmetic1 = 9 - 2; // assigning a value to arithmetic1, using some math.
console.writeline ($"Value of arithmetic1: {arithmetic1} ");
arithmetic1 = 3 + 3; // another assignment.
console.writeline ($"New value of arithmetic1: {arithmetic1} ");
int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic2 all at once.
console.writeline ($"Value of arithmetic2: {arithmetic2} ");
arithmetic2 = 1 + 2; // assigning a second value to arithmetic2
console.writeline ($"New value of arithmetic2: {arithmetic2} ");


// use multiple sets of parentheses to group operations
int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
console.writeline ($"Value of result: {result} ");


/* compund assignment operator */
int compoundAssignmentOperator = 0;
compoundAssignmentOperator += 5; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator + 5; (a is 5 after this line runs.)
compoundAssignmentOperator -= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator - 2; (a is 3 after this line runs.)
compoundAssignmentOperator *= 4; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 after this line runs.)
compoundAssignmentOperator /= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator / 2; (a is 6 after this line runs.)
compoundAssignmentOperator %= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator % 2; (a is 0 after this line runs.)


/* increment and decrement operators */
int  incrementDecrementOperators = 0;
incrementDecrementOperators++; // The equivalent of incrementDecrementOperators += 1; or incrementDecrementOperators = incrementDecrementOperators +1;
incrementDecrementOperators--; // The equivalent of incrementDecrementOperators -= 1; or incrementDecrementOperators = incrementDecrementOperators -1;


console.writeline ("*****");
/* console 2.0 */
console.write ("What is you name, human? "); // notice the space at the end.
string userName = console.readline (); // reads the entire line
// result: What is your name, human? Daniela


console.writeline ("Press any key when you're ready to begin.");
console.readkey (); // reads a keystroke


console.backgroundcolor = consolecolor.yellow; // changes the console background to yellow
console.foregroundcolor = consolecolor.black; // changes the console text to black
console.title = "Hello World!"; // changes the console title


console.beep (440, 1000); // computer beeps


}
}
}
