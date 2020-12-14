# Search Substring in String

### Write on C# language

You need to search substring in string

## Instruction :

To begin with, start program and you can see text "Answer in string out file".
Next go to path file and find your answer.

## Algorithm :

To begin, the algorithm reads the data: string and pattern to search.
Next you can start one of two algorithms: Brute Force or Boyer Moore Algorithm.

### Brute Force Algorithm :

For each element of the ribbon, a loop begins and ends as soon as the characters do not match the pattern.

### Boyer Moore Algorithm :

To begin with, a dictionary is created with values for the skip.
Then we look at the tape, and if we meet a symbol that is not in the pattern, we skip exactly the entire length.
If the symbol is in the pattern, the characters from the dictionary are skipped.
After finding the word additional is incremented i.

If elements are found, its index is added to the letter, if not, then -1.
After that, the answer is written to the source file.