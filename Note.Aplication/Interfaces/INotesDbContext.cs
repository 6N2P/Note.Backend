using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Note.Aplication.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Notes.Domain.Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
