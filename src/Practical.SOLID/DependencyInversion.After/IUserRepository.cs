using System.Data.Common;

namespace DependencyInversion.After
{
    internal interface IUserRepository
    {
        DbDataReader GetUsers();
    }
}
