/*
 * Fun with Arrays
 * 
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
 * 
 */


using System.Runtime.InteropServices.Marshalling;

int numberA = 50, numberB = 49, numberC = 385;
int numberOfNumbers = 3;

int sumOfNumbers = numberA + numberB + numberC;
int average = sumOfNumbers/ numberOfNumbers;


int[] numberArray = [50, 49, 385, 492, 5938, 72, 2, 483, 295, 293, 29, 294];


int numberOfItemsInArray = 12;
int counter;

int secondSumOfNumbers = numberArray[0] + numberArray[1] + numberArray[2];

int anotherSum = 0;

for( counter = 0; counter < numberOfItemsInArray; counter++ )
{
    anotherSum += numberArray[counter];
}

double newAverage = (double)anotherSum / (double)numberOfItemsInArray;



// go through each element in the array
// keep track of the largest number so far
// if the current element is greater than the largest number so far, the largest number so far is the current element

int largestNumber = 0;

// largestNumber = 5938

for (counter = 0; counter < numberOfItemsInArray; counter++)
{
    if (numberArray[counter] > largestNumber )
    {
        largestNumber = numberArray[counter];
    }
}

// largestNumber = 5938


// add ten to each element
for (counter = 0; counter < numberOfItemsInArray; counter++)
{
    numberArray[counter] *= 10;
}


// Declare and set array element values.
int[] array2 = [1, 2, 3, 4, 5, 6];
int[] array3 = [3, 2, 5, 3, 9, 2];

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine("the day is " + weekDays[3]);

double[] temperatureData = { 72.5, 74.0, 76.1, 78.0, 79.5, 81.0, 80.3, 82.0, 83.1, 84.5 };
double[] freezerTemperatureData = { 2.5, 4.0, 6.1, 8.0, 9.5, 1.0, 0.3, 2.0, 3.1, 4.5 };
double tempAlarmThreshold = 5.0;
int overTempCounter = 0;
double sumTemps = 0;
numberOfItemsInArray = 10;

for (counter = 0; counter < numberOfItemsInArray; counter++)
{
    sumTemps += freezerTemperatureData[counter];

    if ( freezerTemperatureData[counter] > tempAlarmThreshold )
    {
        Console.WriteLine("Temp of {0} was over threshold of {1}",
                freezerTemperatureData[counter], tempAlarmThreshold);
        overTempCounter++;
    }
}

// overTempCounter now has the number of times it went over the threshold

double averageTemp = sumTemps / numberOfItemsInArray;
// Set the temperature threshold
double threshold = 5.0;

if( averageTemp > threshold )
{
    // turn on the freezer
}



// Array of product names
string[] productNames = { "Apples", "Bananas", "Cherries", "Dates", "Elderberries" };

// Array of product quantities
int[] quantities = { 15, 5, 22, 8, 12 };

bool[] insufficentStock = new bool[5];

// if the quantity of the item is less than threshold of 10, then print out that we need restock that item

const int restockThreshold = 10;

for (counter = 0; counter < numberOfItemsInArray; counter++)
{
    if(quantities[counter] < restockThreshold)
    {
        insufficentStock[counter] = true;
    } else
    {
        insufficentStock[counter] = false;
    }

}


// Loop through the arrays of product names and quantities
// Check if the stock is sufficient or insufficient



