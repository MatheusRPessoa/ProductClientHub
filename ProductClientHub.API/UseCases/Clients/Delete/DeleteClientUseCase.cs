using ProductClientHub.API.Infrastructure;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Delete
{
    public class DeleteClientUseCase
    {
        public void Execute(Guid clientId)
        {
            var dbContext = new ProductClientHubDbContext();

            var entity = dbContext.Clients.FirstOrDefault(client => client.Id == clientId);
            if (entity == null)
            {
                throw new NotFoundException($"Cliente com ID {clientId} não encontrado.");
            }

            dbContext.Clients.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
