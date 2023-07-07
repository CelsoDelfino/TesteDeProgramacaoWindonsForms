using CsvHelper;
using RefazendoTesteDeProgramacao.Domain.IRepository;
using RefazendoTesteDeProgramacao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefazendoTesteDeProgramacao.Domain.Repository
{
    public class LinhaRepository : ILinhaRepository
    {
        public void SalvarArquivo(List<Linha> linhas)
        {
            using (var writer = new StreamWriter("C:\\Monitorar\\ArquivoCalculado.csv"))
            {
                using (var csv = new CsvWriter(writer, new CultureInfo("pt-br")))
                {
                    csv.WriteRecord(linhas);
                }
            }
        }
    }
}
