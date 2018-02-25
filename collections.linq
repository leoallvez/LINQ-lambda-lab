<Query Kind="Program" />

void Main()
{
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
	
	// Iterate through the list with foreach.  
	foreach (var letter in letters)  
	{  
	    Console.WriteLine(letter);  
	}
	
	// Iterate through the list with for
	for (var index = 0; index < letters.Count; index++)  
	{  
	    Console.Write(letters[index]);  
	}
	
	// Iterate through the list.  
	// A lambda expression is placed in the ForEach method  
	// of the List(T) object.
	var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
	
	numbers.Remove(0);
	List<int> l = new List<int>();
	numbers.Where(m => m > 5).ToList().ForEach(m => l.Add(m));
	
	l.ForEach(x => Console.Write(x));
	
	List<Galaxy> theGalaxies = new List<Galaxy>() {
		new Galaxy() { Name = "Tadpole", MegaLightYears =400},  
        new Galaxy() { Name = "Pinwheel", MegaLightYears =25},  
        new Galaxy() { Name = "Milky Way", MegaLightYears =0},  
        new Galaxy() { Name = "Andromeda", MegaLightYears =3}
	};
		
		
}

public class Galaxy
{
	public string Name {get; set;}
	public int MegaLightYears {get; set;}
}

// Define other methods and classes here
