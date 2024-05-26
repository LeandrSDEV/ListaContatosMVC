using ContatosMVC.Models;
using ContatosMVC.Models.Enums;
using System;

namespace ContatosMVC.Data
{
    public class SeedingService
    {
        private ContatosMVCContext _context;

        public SeedingService(ContatosMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //Operação responsaél por popular o banco de dados
            if (_context.Department.Any() || _context.Sellers.Any() || _context.SalesRecord.Any())
            {
                return; //DB já foi populado
            }           
        }
    }
}

