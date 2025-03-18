﻿using Client_Invoice_System.Data;
using Client_Invoice_System.Models;
using Client_Invoice_System.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Invoice_System.Repository
{
    public class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository(ApplicationDbContext context) : base(context) { }


        public async Task<List<Client>> GetAllClientsWithDetailsAsync()
        {
            return await _context.Clients.Include(c => c.CountryCurrency).AsNoTracking().ToListAsync();
        }

        public async Task<int> GetActiveClientsCountAsync()
        {
            return await _context.Clients.CountAsync();
        }
        public async Task<bool> EmailExistsAsync(string email)
        {
            try
            {
                return await _dbSet.AnyAsync(c => c.Email == email);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking email existence: {ex.Message}");
                return false; // Default to false on failure
            }
        }

        public async Task<Client> GetClientWithResourcesAsync(int clientId)
        {
            try
            {
                return await _dbSet
                    .Include(c => c.Resources)
                    .FirstOrDefaultAsync(c => c.ClientId == clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving client with resources: {ex.Message}");
                return null; // Return null on failure
            }
        }

        public override async Task DeleteAsync(int clientId)
        {
            try
            {
                var client = await _dbSet.FindAsync(clientId);
                if (client == null)
                {
                    Console.WriteLine($"Client with ID {clientId} not found.");
                    return;
                }



                _dbSet.Remove(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting client: {ex.Message}");
            }
        }


        public async Task<Client> GetByIdAsync(int clientId)
        {
            try
            {
                return await _dbSet.FindAsync(clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving client by ID: {ex.Message}");
                return null; // Return null on failure
            }
        }

        public async Task AddAsync(Client client)
        {
            try
            {
                await _dbSet.AddAsync(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding client: {ex.Message}");
            }
        }

        public async Task UpdateAsync(Client client)
        {
            try
            {
                _dbSet.Update(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating client: {ex.Message}");
            }
        }

    }
}
