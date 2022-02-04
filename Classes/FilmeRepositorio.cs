using System;
using System.Collections.Generic;
using AppDeSeries.Interfaces;

namespace AppDeSeries
{
	public class FilmeRepositorio : IRepositorio2<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void AtualizaFilme(int id2, Filme objeto)
		{
			listaFilme[id2] = objeto;
		}

		public void ExcluiFilme(int id2)
		{
			listaFilme[id2].ExcluirFilme();
		}

		public void InsereFilme(Filme objeto)
		{
			listaFilme.Add(objeto);
		}

		public List<Filme> ListaFilme()
		{
			return listaFilme;
		}

		public int ProximoId2()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorId2(int id2)
		{
			return listaFilme[id2];
		}
	}
}