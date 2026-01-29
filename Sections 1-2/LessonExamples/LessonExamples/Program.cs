//explicitly typed variables
string word = "ABC";
int number = 5;

//var keyword
//implicitly typed variables
var word = "ABC";
word = 10; //error: cannot convert from 'int' to 'string'
var number = 5;

var name; //error: Implicitly-typed local variables must be initialized

bool someBoolean = true;
var someOtherBoolean = false;

var number = 10;
var isLargerThanFive = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

var is10Modulo3EqualTo1 = (10 % 3) == 1;

/* short circuiting = put the more lightweight operations on the left hand side */