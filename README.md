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

For the first problem using a n=2
  I included an image showing all posibble states (states-n2.png), the algorith finds the solution but takes the long way, i dont know why takes the long way and not take the answer. For the problem taking the initial state:
  2
3 1
  It has 12 states, in a total, and it takes 11 steps to find the answer.
  
Fow the second problem using a n=3
  I included the expanded states in the image "states-n3.png", the algorithm works efficiently, because all the algorothm was build with this base case.
  Foe the initial state we take the order:
  1 2 0
  3 4 5
  6 7 8
  The number of generate states is 15, and the numbes of generate states until find the answer is 14, for the by the previous explanation. 

The algorithm does'n work for a n=4, for taking the state like a number, and confussing numbers over 10.
  
4. Conclusions: The algorithm in this work finds the way to solve the puzzle only to a one final state only for a n<4, this is because it checking the states converting a state in a number, but it would be more efficient only taking lists.
The bad administration of work and time makes this work incomplete, and the misunderstanding of the problem description makes that i work in only one alrotihm (BFS) and ignore the second algorithm.
This way is an interesting form to solve the 8-puzzle problem, but it has a lot of inconvenients to solve with another "n" that is not 3, so taking the other algorithm not developed, the better way is building nodes, that could have 4 son nodes, one father node, and a string with the steps until that node.                                                                                                                       

5. Bibliography: The algorithm was inspired in another algorithm what is included in this work (8-queen) and i only use some pages to guide how to use the functions of c#.
https://parzibyte.me/blog/2018/10/02/elevar-numero-a-potencia-en-c/
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
https://docs.microsoft.com/es-es/troubleshoot/dotnet/csharp/read-write-text-file 
