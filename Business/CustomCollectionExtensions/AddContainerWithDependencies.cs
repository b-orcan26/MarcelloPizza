using Business.Concrete;
using Business.Interfaces;
using Business.ValidationRules;
using DAL.Concrete;
using DAL.Interfaces;
using DTO;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CustomCollectionExtensions
{
    public static class AddContainerWithDependencies
    {
        public static void AddValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<KategoriAddDTO>, KategoriAddValidator>();
            services.AddTransient<IValidator<UrunAddDTO>, UrunAddValidator>();
            services.AddTransient<IValidator<UserLoginDTO>, UserLoginValidator>();
            services.AddTransient<IValidator<UrunGuncelleDTO>, UrunGuncelleValidator>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUrunRepository, UrunRepository>();
            services.AddScoped<IKategoriRepository, KategoriRepository>();
        }

        public static void AddServiceAndManagers(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IKategoriService, KategoriManager>();
        }

    }
}
