using System;

namespace AppDeSeries
{
    class Program
    {	
        static SerieRepositorio repositorio = new SerieRepositorio();
		static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
			
			 while(opcaoUsuario.ToUpper() != "X")
			 {
			
				switch (opcaoUsuario)
				{
					case "1":
						string opcaoUsuarioFilme = ObterOpcaoUsuarioFilme();

						while (opcaoUsuarioFilme.ToUpper() != "X")
						{ 
							switch (opcaoUsuarioFilme)
							{
								case "1":
									ListarFilmes();
									break;
								case "2":
									InserirFilme();
									break;
								case "3":
									AtualizarFilme();
									break;
								case "4":
									ExcluirFilme();
									break;
								case "5":
									VisualizarFilme();
									break;
								case "C":
									Console.Clear();
									break;

								default:
									throw new ArgumentOutOfRangeException();
							}
							opcaoUsuarioFilme = ObterOpcaoUsuarioFilme();
						}
					break;

					case "2":
						string opcaoUsuarioSerie = ObterOpcaoUsuarioSerie();

						while (opcaoUsuarioSerie.ToUpper() != "X")
						{ 
							switch (opcaoUsuarioSerie)
							{
								case "1":
									ListarSeries();
									break;
								case "2":
									InserirSerie();
									break;
								case "3":
									AtualizarSerie();
									break;
								case "4":
									ExcluirSerie();
									break;
								case "5":
									VisualizarSerie();
									break;
								case "C":
									Console.Clear();
									break;

								default:
									throw new ArgumentOutOfRangeException();
							}
							opcaoUsuarioSerie = ObterOpcaoUsuarioSerie();
						}
					break;
					
					default:
					throw new ArgumentOutOfRangeException();
					
					
				}
				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		 private static void ExcluirFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioFilme.ExcluiFilme(indiceFilme);
		}

        private static void VisualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var Filme = repositorioFilme.RetornaPorId2(indiceFilme);

			Console.WriteLine(Filme);
		}

        private static void AtualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTituloFilme = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAnoFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Filme: ");
			string entradaDescricaoFilme = Console.ReadLine();

			Filme atualizaFilme = new Filme(id2: indiceFilme,
										generofilme: (Genero)entradaGeneroFilme,
										titulofilme: entradaTituloFilme,
										anofilme: entradaAnoFilme,
										descricaofilme: entradaDescricaoFilme);

			repositorioFilme.AtualizaFilme(indiceFilme, atualizaFilme);
		}
        private static void ListarFilmes()
		{
			Console.WriteLine("Segue abaixo lista de filmes");

			var listafilme = repositorioFilme.ListaFilme();

			if (listafilme.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrado.");
				return;
			}

			foreach (var filme in listafilme)
			{
                var excluidoFilme = filme.retornaExcluidoFilme();
                
				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId2(), filme.retornaTituloFilme(), (excluidoFilme ? "*Excluído*" : ""));
			}
		}

        private static void InserirFilme()
		{
			Console.WriteLine("Inserir novo filme");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Filme: ");
			string entradaTituloFilme = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento do Filme: ");
			int entradaAnoFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Filme: ");
			string entradaDescricaoFilme = Console.ReadLine();

			Filme novoFilme = new Filme(id2: repositorioFilme.ProximoId2(),
										generofilme: (Genero)entradaGeneroFilme,
										titulofilme: entradaTituloFilme,
										anofilme: entradaAnoFilme,
										descricaofilme: entradaDescricaoFilme);

			repositorioFilme.InsereFilme(novoFilme);
		}
        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}
		private static string ObterOpcaoUsuario()
		{
			System.Console.WriteLine();
			System.Console.WriteLine("Filmes e Séries ao seu dispor!");
			System.Console.WriteLine("Informe a opcão desejada");
			System.Console.WriteLine("Digite 1 para Filmes");
			System.Console.WriteLine("Digite 2 para Series");
			System.Console.WriteLine("Digite X para Sair");
			System.Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;

		}
        private static string ObterOpcaoUsuarioSerie()
		{
			Console.WriteLine();
			Console.WriteLine("Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Voltar Menu");
			Console.WriteLine();

			string opcaoUsuarioSerie = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioSerie;
		}
		 private static string ObterOpcaoUsuarioFilme()
		{
			Console.WriteLine();
			Console.WriteLine("Filmes a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Filmes");
			Console.WriteLine("2- Inserir novos Filmes");
			Console.WriteLine("3- Atualizar Filme");
			Console.WriteLine("4- Excluir Filme");
			Console.WriteLine("5- Visualizar Filme");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Voltar Menu");
			Console.WriteLine();

			string opcaoUsuarioFilme = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioFilme;
		}
    }
}
