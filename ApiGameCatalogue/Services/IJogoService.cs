using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGameCatalogue.ViewModel;
using ApiGameCatalogue.InputModel;

namespace ApiGameCatalogue.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade); // aplicação de paginação
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo); // atualiza por completo
        Task Atualizar(Guid id, double preco); // atualiza só o preço
        Task Remover(Guid id);
    }
}
