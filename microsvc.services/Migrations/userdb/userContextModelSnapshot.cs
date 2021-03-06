// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using microsvc.services.DbRepos.User;

namespace microsvc.services.Migrations.userdb
{
    [DbContext(typeof(userContext))]
    partial class userContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("microsvc.services.DbRepos.User.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
