<Query Kind="Program">
  <Connection>
    <ID>5535cf82-606f-4b7c-9e70-985f7dd01300</ID>
    <Persist>true</Persist>
    <Server>LEO-ALVES\SQLEXPRESS</Server>
    <Database>lamb</Database>
    <AlphabetizeColumns>true</AlphabetizeColumns>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Expressions.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Parallel.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.Queryable.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Reflection.Emit.ILGeneration.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	void Main()
	{
		Pessoas.Where (p => p.Nome.Equals("Maria")).Dump();
		
		Pessoas.Where(p => p.Nome.Contains("S")).Dump();
		
		Pessoas.Where(p => p.Matriculas.Where(m => m.Id == 1).Any()).Dump();
		// Create a new element.
		IQueryable result = Matriculas.Where(m => m.Pessoa.Id > 1 )
			.Select(s => new { 
				AlunoId = s.Pessoa.Id,
				AlunoNome = s.Pessoa.Nome,
				AlunoIdade = s.Pessoa.Idade,
				MatriculaId = s.Id,
				MatriculaDescricao = s.Descricao
			}).Take(2).Dump();
			
		
		var sql = result.ToString().Dump();
	}
	
	
}

// Define other methods and classes here
