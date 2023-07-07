using RefazendoTesteDeProgramacao.Domain.Model;

namespace RefazendoTesteDeProgramacao.Api.Resource
{
    public class LinhaResource
    {
        public double ColunaAB { get; set; }


        public Linha ConverteParaEntidade()
        {
            return new Linha { ColunaAB = this.ColunaAB };
        }

        public static List<Linha> ConverteListaEntidade(List<LinhaResource> listaResource) 
        {
            List<Linha> linhas= new List<Linha>();

            LinhaResource linhaResource = new LinhaResource();

            foreach(var linha in listaResource)
            {
                linhas.Add(linhaResource.ConverteParaEntidade());
            }

            return linhas;
        }
    }
}
