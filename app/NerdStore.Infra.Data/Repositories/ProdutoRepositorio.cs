using NerdStore.Domain.Repositories;

namespace NerdStore.Infra.Repositories
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public string ObterCodigo()
        {
            return "0001";
        }
    }
}
