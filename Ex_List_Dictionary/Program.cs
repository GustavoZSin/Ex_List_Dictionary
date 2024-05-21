#region Coleção de Listas

using Ex_List_Dictionary;

CadProdutos cadProdutos = new CadProdutos();

Produto tv = new Produto("TV", 900.00, 10);
Produto videogame = new Produto("Video Game", 1300.00, 5);
Produto notebook = new Produto("Notebook", 1200.00, 20);

cadProdutos.Adicionar(tv);
cadProdutos.Adicionar(videogame);
cadProdutos.Adicionar(notebook);

cadProdutos.Listar();

Console.WriteLine(cadProdutos.Pesquisar("TV"));
Console.WriteLine(cadProdutos.Pesquisar("Smartphone"));

cadProdutos.AtualizarPreco("TV", 1000.00);

cadProdutos.Remover("Smartphone");
#endregion

#region Coleção de Dicionários



#endregion

#region Coleção de Listas de Dicionários



#endregion