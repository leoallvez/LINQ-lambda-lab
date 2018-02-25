<Query Kind="Program">
  <Connection>
    <ID>5535cf82-606f-4b7c-9e70-985f7dd01300</ID>
    <Persist>true</Persist>
    <Server>LEO-ALVES\SQLEXPRESS</Server>
    <Database>lamb</Database>
    <AlphabetizeColumns>true</AlphabetizeColumns>
  </Connection>
</Query>


void Main() {

	var list = new List<int>() {22 ,10 ,0 ,1 , 2, 3, 4, 5, 6, 7, 8, 9}.Dump();
	
	IEnumerable<int> filteredList = list.OrderBy(m => m);
	
	filteredList.Dump();

	filteredList = list.Where(Filtre);
	
	filteredList.Dump();
	
	filteredList = filteredList.Take(2);
	
	filteredList.Dump();
}

public bool Filtre(int i) {
	return i > 4;
}
