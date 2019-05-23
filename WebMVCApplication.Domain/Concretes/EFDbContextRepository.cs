namespace WebMVCApplication.Domain.Concretes
{
    using System.Data.Entity;
    using WebMVCApplication.Domain.Entities;

    public partial class EFDbContextRepository : DbContext
    {
        public EFDbContextRepository() : base("name=Database") { }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
