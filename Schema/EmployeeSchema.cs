using System;
using GraphQL.Utilities;
using graphql_dotnet.Queries;


namespace graphql_dotnet.Schema
{
    public class EmployeeSchema : GraphQL.Types.Schema
    {
        public EmployeeSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetRequiredService<EmployeeQuery>();
        }
    }
}