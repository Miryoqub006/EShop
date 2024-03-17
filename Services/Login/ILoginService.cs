//----------------------------------------
// Miryoqub tg:@Avenger_uzb A.K.A (c) All rights reserved
//----------------------------------------

using EShop.Models.Auth;

namespace EShop.Services.Login
{
    public interface ILoginService
    {
        bool CheckUserLogin(Credential credential);
    }
}