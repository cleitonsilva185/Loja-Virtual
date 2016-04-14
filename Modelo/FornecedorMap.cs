using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using FluentNHibernate.Mapping;

namespace Modelo
{
    public class FornecedorMap: ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.Nome);
            
        }
    }
}
