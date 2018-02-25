<Query Kind="Program">
  <Output>DataGrids</Output>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Expressions.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Parallel.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Queryable.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Reflection.Emit.ILGeneration.dll</Reference>
</Query>

void Main()
{
	var macho = new Gato();
	var femea = new Gato();
	
	var filhote = (new Gato()).Cruzar(macho, femea);
}

public abstract class Mamifero<T> where T: Mamifero<T>
{
	public T Pai {get; set;}
	public T Mae {get; set;}
	public decimal Peso {get; set;}	
	
	public T Cruzar(T macho, T femea) 
	{
		//Criar uma instancia de Gererics.
		var filhote = Activator.CreateInstance<T>();
		filhote.Pai = macho;
		filhote.Mae = femea;
		
		return filhote;
	} 
}

public class Gato : Mamifero<Gato>
{
	public string Raca {get;set;}
	public int Bigode {get; set;}
}

public class Elefante : Mamifero<Elefante>
{
	public int Tromba {get; set;}
}