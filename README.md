# Inheritance

Part I: Inheritance
1. Single Inheritance
Create two classes named Animal and Dog.
Animal with a single public method Eat() that prints: "eating"
Dog with a single public method Bark() that prints: "barking";
Dog should inherit from Animal.

2. Multiple Inheritance
Create three classes named Animal, Dog and Puppy.
Animal with a single public method Eat() that prints: "eating";
Dog with a single public method Bark() that prints: "barking";
Puppy with a single public method Weep() that prints: "weeping";
Dog should inherit from Animal. Puppy should inherit from Dog.

3. Hierarchical Inheritance
Create three classes named Animal, Dog and Cat.
Animal with a single public method Eat() that prints: "eating";
Dog with a single public method Bark() that prints: "barking";
Cat with a single public method Meow() that prints: "meowing";
Dog and Cat should inherit from Animal.

4. Random List
Create a RandomList class that has all the functionality of ArrayList.
Add additional function that returns and removes a random element from the list.
 Public method: RandomString(): string

5. Stack of Strings
Create a class StackOfStrings which can store only strings and has the following functionality:
 Private field: data: List&lt;string&gt;
 Public method: Push(string item): void
 Public method: Pop(): string
 Public method: Peek(): string
 Public method: IsEmpty(): bool

Problem 1. Person
You are asked to model an application for storing data about people. You should be able to have a person and a
child. The child is derived of the person. Your task is to model the application. The only constraints are:
- People should not be able to have negative age
- Children should not be able to have age more than 15.
 Person – represents the base class by which all others are implemented
 Child - represents a class which is derived by the Person.

Problem 2. Book Shop
© Software University Foundation (softuni.org). This work is licensed under the CC-BY- NC-SA license.
Follow us: Page 5 of 11
You are working in a library. And you are pissed of writing descriptions for books by hand, so you wish to use the
computer to speed up the process. The task is simple - your program should have two classes – one for the ordinary
books – Book, and another for the special ones – GoldenEditionBook. So let’s get started! We need two classes:
 Book - represents a book that holds title, author and price. A book should offer information about itself in the
format shown in the output below.
 GoldenEditionBook - represents a special book holds the same properties as any Book, but its price is always
30% higher.
Constraints
 If the author’s second name is starting with a digit– exception’s message is: "Author not valid!";
 If the title’s length is less than 3 symbols – exception’s message is: "Title not valid!";
 If the price is zero or it is negative – exception’s message is: "Price not valid!";
 Price must be formatted to one symbol after the decimal separator

Problem 3. Mankind
Your task is to model an application. It is very simple. The mandatory models of our application are 3: Human,
Worker and Student.
The parent class – Human should have first name and last name. Every student has a faculty number. Every worker
has a week salary and work hours per day. It should be able to calculate the money he earns by hour. You can see
the constraints below.
Input
On the first input line you will be given info about a single student - a name and faculty number.
On the second input line you will be given info about a single worker - first name, last name, salary and working
hours.
Output
You should first print the info about the student following a single blank line and the info about the worker in the
given formats:
 Print the student info in the following format:
First Name: {student's first name}
Last Name: {student's last name}
Faculty number: {student's faculty number}
 Print the worker info in the following format:
First Name: {worker's first name}
Last Name: {worker's second name}
Week Salary: {worker's salary}
Hours per day: {worker's working hours}
Salary per hour: {worker's salary per hour}
Print exactly two digits after every double value&#39;s decimal separator (e.g. 10.00). Consider the workweek from
Monday to Friday. A faculty number should be consisted only of digits and letters.

Problem 4. Online Radio Database
Create an online radio station database. It should keep information about all added songs. On the first line you are
going to get the number of songs you are going to try to add. On the next lines you will get the songs to be added in
the format <artist name>;<song name>;<minutes:seconds>. To be valid, every song should have an artist name, a
song name and length.
Design a custom exception hierarchy for invalid songs:
 InvalidSongException
  o InvalidArtistNameException
  o InvalidSongNameException
  o InvalidSongLengthException
     InvalidSongMinutesException
     InvalidSongSecondsException
Validation
 Artist name should be between 3 and 20 symbols.
 Song name should be between 3 and 30 symbols.
 Song length should be between 0 second and 14 minutes and 59 seconds.
 Song minutes should be between 0 and 14.
 Song seconds should be between 0 and 59.
