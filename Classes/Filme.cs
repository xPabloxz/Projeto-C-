using System;

namespace AppDeSeries
{
    public class Filme : EntidadeBase
    {
		private Genero GeneroFilme { get; set; }
		private string TituloFilme { get; set; }
		private string DescricaoFilme { get; set; }
		private int AnoFilme { get; set; }
        
        private bool ExcluidoFilme {get; set;}

		public Filme(int id2, Genero generofilme, string titulofilme, string descricaofilme, int anofilme)
		{
			this.Id2 = id2;
			this.GeneroFilme = generofilme;
			this.TituloFilme = titulofilme;
			this.DescricaoFilme = descricaofilme;
			this.AnoFilme = anofilme;
            this.ExcluidoFilme = false;
		}

        public override string ToString()
		{
			
            string retorno = "";
            retorno += "Gênero: " + this.GeneroFilme + Environment.NewLine;
            retorno += "Titulo: " + this.TituloFilme + Environment.NewLine;
            retorno += "Descrição: " + this.DescricaoFilme + Environment.NewLine;
            retorno += "Ano de Início: " + this.AnoFilme + Environment.NewLine;
            retorno += "Excluido: " + this.ExcluidoFilme;
			return retorno;
		}

        public string retornaTituloFilme()
		{
			return this.TituloFilme;
		}

		public int retornaId2()
		{
			return this.Id2;
		}
        public bool retornaExcluidoFilme()
		{
			return this.ExcluidoFilme;
		}
        public void ExcluirFilme() {
            this.ExcluidoFilme = true;
        }
    }
}