
namespace PartialClassSample
{
    public partial class User : IRegister, ILogin
    {
        public bool Register(string username, string password)
        {
            //code for register user and store data in DB.

            return true;
        }

    }
}
