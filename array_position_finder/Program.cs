﻿int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int n = array.Length;

int find = 6;
int index = 0;

while (index < n)
{
    if (array[index] == find) 
        {
            Console.WriteLine($"The position of number {find} is {index}");
            break;
        }
    else 
    {
        Console.WriteLine($"The numder {4} wasnt find in array. {array[index]}");
    }
    index ++;
}