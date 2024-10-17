How Does a Recursive Descent Parser Work?
==
Top-Down Approach: It begins at the start symbol of the grammar and breaks down the input by recursively calling functions based on the grammar rules.
Recursive Functions: For each non-terminal, there is a function that tries to parse the input based on the corresponding grammar rule.
Backtracking (Optional): In some cases, if one rule fails, the parser may try another (this can lead to inefficiencies, so some parsers avoid it).


Limitations of Recursive Descent Parsers:
==
Left Recursion: Recursive descent parsers don’t work well with left-recursive grammars because they can lead to infinite recursion. For example, a rule like:
E → E + T
would cause the parser to keep calling E without making progress.
Backtracking: If the grammar has multiple rules that can match the same input, the parser may need to backtrack, which can be inefficient. Left-factoring can help fix this.
