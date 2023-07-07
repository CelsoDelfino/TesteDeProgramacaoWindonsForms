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


namespace RefazendoTesteDeProgramacao.Application
{
    public class LinhaApplication
    {
        private readonly ILinhaRepository repository;
        public LinhaApplication(ILinhaRepository repository)
        {
            this.repository = repository;
        }

        public void Post(List<Linha> linhas)
        {
            repository.SalvarArquivo(linhas);
        }

    }
}
