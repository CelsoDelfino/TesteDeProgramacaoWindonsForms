﻿using RefazendoTesteDeProgramacao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefazendoTesteDeProgramacao.Domain.IRepository
{
    public interface ILinhaRepository
    {
        public void SalvarArquivo(List<Linha> linhas);

    }
}
