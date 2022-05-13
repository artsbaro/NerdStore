using Microsoft.Extensions.DependencyInjection;
using NerdStore.Application;
using NerdStore.Application.Interfaces;
using NerdStore.Application.Notificacoes;
using NerdStore.Domain.Repositories;
using NerdStore.Infra.Repositories;

namespace NerdStore.CrossCutting
{
    public static class NativeBootstraperRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IServicoCategoria, ServicoCategoria>();

            services.AddScoped<INotificador, Notificador>();


            // services.AddScoped -> Mantem o estado do objeto/servico enquanto durar a requisição
            // services.AddSingleton -> Mantem o estado do objeto/servico enquanto a aplicação estiver rodando
            // services.AddTransient -> Não mantem o estado do objeto/servico.
        }
    }
}
