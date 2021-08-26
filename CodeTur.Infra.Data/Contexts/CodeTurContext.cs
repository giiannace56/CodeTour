using codetur.dominio;
using Microsoft.EntityFrameworkCore;


namespace CodeTur.Infra.Data.Contexts
{
   public  class CodeTurContext : DbContext
   {                                                            //Herdando caracteristica base                 
        public CodeTurContext(DbContextOptions<CodeTurContext> options) : base(options)
        {

        }


        //Declarando as tabelas criadas com DBset
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notifications>();

            #region Mapeamento de tabela de usuarios

            //Caso deseje mudar o nome da tabela
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            //Como está nomeado como ID , não precisa dizer quem é a chave primaria da tabela
            modelBuilder.Entity<Usuario>().Property(x => x.ID);

            //Nome
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("varchar(40");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            //Email
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(60);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("varchar(200");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();

            //Senha
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(60);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("varchar(80");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            //Data
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasColumnType("DateTime(200");

            //Configração de relacionamentos
            modelBuilder.Entity<Usuario>();
            .HasMany(c => c.Comentarios)
            .WithOne(u => u.Usuario)
            .HasForeignKey(fk => fk.idUsuario)
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
