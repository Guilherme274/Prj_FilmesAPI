using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

public class FilmeContext : DbContext  //contexto de bancco de dados
{
	public FilmeContext(DbContextOptions<FilmeContext> opts)
		: base(opts)
	{

	}

	public  DbSet<Filme> Filmes { get; set; }
}
