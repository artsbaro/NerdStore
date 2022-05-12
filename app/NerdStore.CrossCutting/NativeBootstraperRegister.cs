using System;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Application;
using NerdStore.Application.Interfaces;
using NerdStore.Domain.Repositories;
using NerdStore.Infra.Repositories;

namespace NerdStore.CrossCutting
{
    public static class NativeBootstraperRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddTransient<IServicoCategoria, ServicoCategoria>();

            //services.AddSingleton<ICategoriaRepositorio, CategoriaRepositorio>();
            //services.AddSingleton<IProdutoRepositorio, ProdutoRepositorio>();
            //services.AddSingleton<IServicoCategoria, ServicoCategoria>();
        }
    }
}
