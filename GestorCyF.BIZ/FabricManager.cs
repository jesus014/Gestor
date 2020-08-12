using GestorCyF.COMMON.Entidades;
using GestorCyF.COMMON.Validadores;
using GestorCyF.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestorCyF.BIZ
{
    public static class FabricManager
    {
        public static ClientesManager Clientes (string pathDB)
        {
            return new ClientesManager(new GenericRepository<Clientes>(new ClientesValidator(), pathDB));
        }
    }
}
