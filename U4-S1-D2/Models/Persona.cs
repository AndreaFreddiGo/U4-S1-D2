namespace U4_S1_D2.Models
{
    public class Persona
    {
        public string _nome;
        public string _cognome;
        public int _eta;

        public Persona(string nome, string cognome, int eta)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
        }

       public void GetNome()
        {
            Console.WriteLine($"Nome: {_nome}");
        }

        public void GetCognome()
        {
            Console.WriteLine($"Cognome: {_cognome}");
        }

        public void GetEta()
        {
            Console.WriteLine($"Età: {_eta}");
        }
        public void GetDettagli ()
        {
            Console.WriteLine($"Nome: {_nome} Cognome: {_cognome} Età: {_eta}");
        }
    }


}
