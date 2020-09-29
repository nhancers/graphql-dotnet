namespace graphql_dotnet.Models.DbEntities
{
    public class Employee
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public Department Department{get;set;}
    }
}