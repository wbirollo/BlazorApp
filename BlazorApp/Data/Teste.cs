namespace BlazorApp.Data
{
    public class Teste
    {
        public int Id_Sistema { get; set; }
        public string Descricao { get; set; }

        public Teste()
        {
        }

        public Teste(int id_Sistema, string descricao)
        {
            Id_Sistema = id_Sistema;
            Descricao = descricao;
        }
    }
}
