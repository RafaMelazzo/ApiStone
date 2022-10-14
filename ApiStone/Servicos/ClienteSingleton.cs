using ApiStone.Models;
using System.Collections.Generic;

namespace ApiStone.Servicos
{
    public class ClienteSingleton
    {
        private ClienteSingleton(){}
        private static ClienteSingleton clienteSingleton;

        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Clientes()
        {
            return clientes;
        }

        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static ClienteSingleton GetInstancia()
        {
            if (clienteSingleton == null)
                clienteSingleton = new ClienteSingleton();

            return clienteSingleton;
        }
    }
}
