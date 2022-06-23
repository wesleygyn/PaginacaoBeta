using PaginacaoBeta.Models;

namespace PaginacaoBeta.ViewModels
{
    public class PaginacaoDto
    {
        public Paginacao paginacao { get; set; }
        public IEnumerable<Categoria> Items { get; set; }
    }
}
