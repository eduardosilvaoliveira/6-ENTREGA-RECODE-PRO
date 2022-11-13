namespace AgenciaAPI.Model
{
    public class Agencia
    {
        public Agencia(int id, string editar) 
        {
            this.Id = id;
    this.Editar = editar;
   
        }
                public int Id { get; set; }
        public string Adicionar { get; set; }
        public string Editar { get; set; }
        public string Deletar { get; set; }


    }
}
