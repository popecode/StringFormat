# StringFormat
A Simple String format tool for replacing certain characters.

Place your DATA into the input textbox. 

Select your split character. For csv files this would be a comma ','

Select your desired output replacing the desired location of your input with [0], [1], ect.
Click 'Format' and obtain your formatted text from the output text box.

N.B. This can handle multiple lines.
N.B Clear All has not been implemented.


An example.

Input: 

HelloCode, SomethingCode
NothingCode, JokeCode

Format:
INSERT INTO [SomeDatabase]([0], [1])

Split character = ','

Results in an output of
INSERT INTO [SomeDatabase](HelloCode,  SomethingCode)
INSERT INTO [SomeDatabase](NothingCode,  JokeCode)
