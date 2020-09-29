using System.Linq;
using GraphQL;
using GraphQL.Types;
using graphql_dotnet.Database;
using graphql_dotnet.GraphqlTypes;

namespace graphql_dotnet.Queries
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(ApplicationDbContext db)
        {
            Field<Employee>(
              "Employee",
              arguments: new QueryArguments(
                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Employee." }),
              resolve: context =>
              {
                  var id = context.GetArgument<int>("id");
                  var employee = db
                                .Employees
                                .FirstOrDefault(i => i.Id == id || id == 0);
                                    return employee;
              });
        }
    }
}
