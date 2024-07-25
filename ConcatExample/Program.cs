// Concat
using System.Collections;

var boyNames = new List<string>() { "Ali", "Osama", "Saber"};
var girlNames = new List<string>() { "Sara", "Warda", "Fatima"};

var boyAndGirlNames = boyNames.Concat(girlNames);

foreach(var name in boyAndGirlNames)
    Console.WriteLine(name);

Console.WriteLine("----------------------------------------------------");


// OfType => filters the collection based on a given type
var items = new ArrayList()
{
    11, true, "Hi", 20, "Hello", false, 'A', 'B', 'C',
};

// Method Syntax (OfType)
var result = items.OfType<string>();

// Query Syntax (OfType)
var resultQuery = from value in items.OfType<string>() 
                  select value;

foreach (var item in resultQuery)
    Console.WriteLine(item);

Console.ReadKey();
