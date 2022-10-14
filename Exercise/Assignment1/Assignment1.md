# Assignment 1

## Topics:
>> ### Random numbers
>> ### Class
>> ### Loops
>> ### Selections
>> ### Data validation
>> ### Handling of exceptional cases

### Given in project 
>> [The class RandomNumbers](RandomNumbers.cs).

>> The test project **ExerciseTester**

## Construct a **public** Class **RandomNumbers** with:
1. **private** readonly attributes *int _count, Random _random* 
>> The attribute _count is used to specify how many numbers the method RandomValues can produce. 

>> The attribute _random is of type Random and is used to generate random numbers. 

2. **public** Constructor taking **two** parameters *int count* , *int seed* 
>> The parameter count for initializing attribute _count. 

>> The parameter seed for seeding the attribute _random. 

3. A **public** Metod:  *List\<int> RandomValues(int minValue,int maxValue)*
>> The method returns a List of length _count of random integers with values between minValue and maxValue both included. 

4. The following exceptions should be handled
>> If count is \< 0 or \> 1000  the string **Illegal count \{count\}** should be written to the console and the _count attribute should be set to 0. 

>> In method **RandomValues** if
>>> minValue is \< 10 or \> 99 the text **Illegal minimum \{min\}** should be written to the console and an empty list returned

>>> maxValue is max is \< 11 or \> 100 the text **Illegal maxmum \{max\}** should be written to the console and an empty list returned

>>> maxValue \<= minValue the text **Max \{max\} must be greater than min \{min\}** should be written to the console and an empty list returned;