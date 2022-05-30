﻿using CnabContasPagar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNABContasPagar.Interfaces
{
    public interface IBanco
    {
        string MontarArquivo(List<Liquidacao> liquidacoes);
        void HeaderArquivo(StringBuilder b);
        void DetalhePagamentoComum(StringBuilder b, Liquidacao liquidacao);
        void HeaderDetalheComum(StringBuilder b, Liquidacao liquidacao);
        void DetalheA(StringBuilder b, Liquidacao liquidacao);
        void TrailerDetalheComum(StringBuilder b, Liquidacao liquidacao);
        void TrailerArquivo(StringBuilder b);
        string ValidaPagto(string formaPagto, string numeroBanco, bool corretora, string agencia, string conta);
        string ExisteCodBarras(string formaPagto, string codBarras);
        bool ValidaCodBarras(string formaPagto, string codBarras);
        Opcoes Opcoes { get; set; }
    }
}
