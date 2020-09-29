using GraphQL.Types;

namespace graphql_dotnet.GraphqlTypes
{
    public class Employee : ObjectGraphType<Models.DbEntities.Employee>
    {
        public Employee()
        {
            Name = "Employee";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Employee.");
            Field(x => x.Name).Description("The name of the Employee");
            Field(x => x.Department, type: typeof(Department)).Description("Department");
        }
    }
}