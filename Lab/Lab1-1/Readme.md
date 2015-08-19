# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 

##Natthapong Burakitphachai 570611011

## Revision, put your commit number here
* Sort from larger to smaller: e75f6743
* Without flag: ce773753

## Questions
1. How this code can sort number from smaller to larger
 
Answer: By traversing through the input array, counting from i=0 and increase i every turn until the last member of the array. 
checking if the value of position i is higher than the value of position i+1. if the condition is true then create the temporary variable to keep the
value in i, swap between value in i and i+1. then turn flag to true to continue to next member of the array.
   
2. What if two numbers equal, what will happen? 

Answer: Move to next member in the array. It doesn't met the condition in line 24 so the swaping does't happen.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 24 times.

4. Why we need flag variable ? 

Answer: To keep the loop going until the last member of the array then end the loop.
		flag = true; -- to keep the loop going.
		flag = false; -- to end the loop if every members are sorted.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: The code 'll run faster if we remove the flag variable (included removing the while (flag))
		because we decrease the recursion (the loop). but the member won't be sorted correctly.