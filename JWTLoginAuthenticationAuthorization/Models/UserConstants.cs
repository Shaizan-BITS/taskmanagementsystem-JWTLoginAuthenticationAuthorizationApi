namespace TMS.JWTLoginAuthenticationAuthorization.Api.Models
{
    // We are not taking data from data base so we get data from constant
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="admin",Password="admin",Role="Admin"},
                    new UserModel(){ Username="user",Password="user",Role="EndUser"},
                    new UserModel(){ Username="shaizan.khan",Password="1234567",Role="EndUser"}
            };
    }
}
