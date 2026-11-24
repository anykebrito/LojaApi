
 using LojaApi.Model;
using LojaApi.Repositories;
 
namespace LojaApi.Services;
 
/*
    Responsável por coordenar
    as operações relacionadas aos produtos.
 
    O Service recebe as solicitações
    do Controller e chama o Repository
    para acessar os dados.
*/
public class ProdutoService
{
    private readonly ProdutoRepository _produtoRepository;
 
    /*
        Recebe o Repository
        por meio da injeção de dependência.
    */
    public ProdutoService(ProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }
 
    /*
        Lista todos os produtos cadastrados.
 
        Solicita ao Repository os dados
        e devolve a lista de produtos.
    */
    public async Task<List<Produto>> ListarAsync()
    {
        return await _produtoRepository.ListarAsync();
    }
}