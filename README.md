# Sis_Inteligentes
1. Problem description: In this work, Tried to program the '(n-1)-puzzle' problem, where we have a chart with consecutive numbers starting from 1 and a space. The inicial state of numbers are in a random order, and we want to solve the problem using the algorithm BFS, and show all the possible states.

2. Solition description: We want to get into a final state, using the algorithm BFS, exploring the states until find the final state.

3. Experiments y results: Well, the problem suggest a way of solution using a matrix, but I see another way using a simple array, putting a few conditions and using the functions of C#, so the chart is a List of integers (List<int>).
To start the whole algorithm builds 3 list, one to the chart, one to have a queue, and another to save the steps to get to a state, the queue list and the steps list are very related, because the have the same index.
The queue list saves the states like numbers, for example, we have the state:
123
456
78
And the queue list saves that state like the number "123456780" taking the space like a zero, we don't see a diference between take the space like a zero or like a 'null' so i prefer save like a cero to try to avoid posibble error with nulls.
And the steps list saves the steps in a string, adding a step with the direction and a comma, for example: Derecha, 
So we have two list of integers and one list of strings, apart of the variables to guide through the algorithm.
Explaining the algorithm, first build the lists, then expand the posibble states before cheking if the state is the answer, this is because it was a problem checking the actual state at starup, and we solve that problem only changing that order, we have more states, but is only one or two states more.
I use a lot of "for"'s so maybe the algorithm is not the most efficient, but it works, and it use the secure and base way.

I was inspyred by a previous problem with the 8-queen problem, because i think in that way and i just used because i want follow my first idea, i know that is not the most efficient, but i can say that is my idea.

4. Conclusions: The algorithm in this work finds the way to solve the puzzle only to a one final state, but it could be to any final state only changing the checking. 
The bad administration of work and time makes this work incomplete, and the misunderstanding of the problem description makes that i work in only one alrotihm (BFS) and ignore the second algorithm.

5. Bibliography: The algorithm was inspired in another algorithm what is included in this work (8-queen) and i only use some pages to guide how to use the functions of c#.
https://parzibyte.me/blog/2018/10/02/elevar-numero-a-potencia-en-c/
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
https://docs.microsoft.com/es-es/troubleshoot/dotnet/csharp/read-write-text-file 
