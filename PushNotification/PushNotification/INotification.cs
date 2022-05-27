using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PushNotification
{
    public interface INotification
    {
        void CreateNotification(String title, String message);
        String getAuthKey();
        bool IsUserSigned();
        Task<bool> SignUp(String email, String password);
        Task<bool> SignIn(String email, String password);
        void SignInWithGoogle();
        Task<bool> SignInWithGoogle(String token);
        Task<bool> Logout();
        String GetUserId();
    }
}
