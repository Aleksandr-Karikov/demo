using DemoExamen.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamen.Services
{
    internal static class AuthService
    {
        static public User Login(LoginDto loginDto)
        {
            using (TradeEntities context = new TradeEntities())
            {
                var userLogin = context.User.Where(user => user.UserLogin == loginDto.Login && user.UserPassword == loginDto.Password).FirstOrDefault();
                if (userLogin == null)
                {
                    throw new Exception("Не верный логин или пароль");
                }
                return userLogin;
            }
        }
    }
}
