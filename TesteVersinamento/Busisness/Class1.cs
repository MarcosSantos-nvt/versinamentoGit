namespace Busisness
{
    public class Class1
    {
        public string Texto { get; set; }

        public Class1(string texto)
        {
            Texto = texto;
        }

        public string RetornaUmTexto()
        {
            return Texto;
        }
    }
}