Simple Genetic Algorithm Project AI
-----------------------------------------------------------

GENETIC ALGORITHM:-
Genetic Algorithms(GAs) are adaptive heuristic search algorithms that belong to the larger part of evolutionary algorithms. Genetic algorithms are based on the ideas of natural selection and genetics.
These are intelligent exploitation of random search provided with historical data to direct the search into the region of better performance in solution space. 

-----------------------------------------------------------

I have used a simple card splitting exercise using Genetic Algorithm.
Let’s suppose:
	You have 10 cards numbered 1 to 10
	You have to divide them into two piles so that:
	The sum of the first pile is as close as possible to 36.
	And the product of all in the second pile is as close as possible to 360.
  
-----------------------------------------------------------

The basic operation of the Microbial GA training is as follows:

Pick two genotypes at random
Compare Scores (Fitness) to come up with a Winner and Loser
Go along genotype, at each locus (Point)
That is:

With some probability (randomness), copy from Winner to Loser (overwrite)
With some probability (randomness), mutate that locus of the Loser
So only the Loser gets changed, which gives a version of Elitism for free, this ensures that the best in the breed remains in the population.

That's it. That is the complete algorithm.

-----------------------------------------------------------
How to Use?

Clone this repository,
before running this project make sure to connect database for login credentials,
of you don't want to add database then goto Program.cs and change the line:  Application.Run(new Form2()); to Application.Run(new Form1());
