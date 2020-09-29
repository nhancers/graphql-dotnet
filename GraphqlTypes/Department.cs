using GraphQL.Types;

namespace graphql_dotnet.GraphqlTypes
{
    public class Department : ObjectGraphType<Models.DbEntities.Department>
    {
        public Department()
        {
            Name = "Department";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Department.");
            Field(x => x.Name).Description("The name of the Department");
            Field(x => x.Employees, type: typeof(ListGraphType<Employee>)).Description("Department employees");
        }
    }
}