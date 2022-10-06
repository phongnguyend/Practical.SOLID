using System.Data.SqlClient;

namespace DependencyInversion.Before
{
    internal interface IUserRepository
    {
        SqlDataReader GetUsers(SqlConnection sqlConnection);
    }
}
