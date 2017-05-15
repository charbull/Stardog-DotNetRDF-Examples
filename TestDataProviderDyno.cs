using System;
using DynamicSPARQLSpace.dotNetRDF;
using VDS.RDF;
using VDS.RDF.Query.Datasets;

namespace dotNetRDFExample
{
    public static class TestDataProviderDyno
    {
        public static dynamic GetDyno(TripleStore store)
        {
            DynamicSPARQLSpace.dotNetRDF.Connector connector = null;

            var store = new VDS.RDF.TripleStore();
            
            connector = new Connector(new InMemoryDataset(store));
         
            dynamic dyno = DynamicSPARQL.CreateDyno(connector.GetQueryingFunction());

            return dyno;
        }
    }
}