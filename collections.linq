<Query Kind="Statements" />

// Create a list of strings.
List<string> colors = new List<string>();

colors.Add("Pink");
colors.Add("White");
colors.Add("Blue");
colors.Add("Green");
colors.Add("Black");

// Iterate through the list
foreach(string color in colors) {
	Console.WriteLine(color);
}
// Output: White Blue Green Black 


// Create a list of strings by using a  
// collection initializer.  
var letters = new List<string> { "A", "B", "C", "D" };  

// Remove an element from the list by specifying  
// the object.  
letters.Remove("A");  

// Iterate through the list.  
foreach (var letter in letters)  
{  
    Console.WriteLine(letter);  
}