﻿using StudentManagement.Api.Models.AuthModels;

namespace StudentManagement.Api.Services
{
    public interface IAuthenticationService
    {
        Task<(int, string)> Registration(RegistrationModel model, string role);
        Task<(int, string)> Login(LoginModel model);
    }
}
 