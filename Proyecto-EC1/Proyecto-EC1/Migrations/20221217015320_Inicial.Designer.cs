// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_EC1;

namespace Proyecto_EC1.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221217015320_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_EC1.Entitys.Categoria", b =>
                {
                    b.Property<int>("Id_catg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nom_catg")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_catg");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Cliente", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("fech_nac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("tip_doc")
                        .HasColumnType("int");

                    b.HasKey("Id_Cliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Detalle_pedido", b =>
                {
                    b.Property<int>("Id_dped")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_pedido")
                        .HasColumnType("int");

                    b.Property<int>("Id_prod")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId_pedido")
                        .HasColumnType("int");

                    b.Property<int?>("ProductoId_prod")
                        .HasColumnType("int");

                    b.Property<int>("cant")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.Property<float>("subtotal")
                        .HasColumnType("real");

                    b.HasKey("Id_dped");

                    b.HasIndex("PedidoId_pedido");

                    b.HasIndex("ProductoId_prod");

                    b.ToTable("Detalle_pedido");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Pedido", b =>
                {
                    b.Property<int>("Id_pedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("fech_entr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fech_ped")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hor_ped")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("obs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_pedido");

                    b.HasIndex("ClienteId_Cliente");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Producto", b =>
                {
                    b.Property<int>("Id_prod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId_catg")
                        .HasColumnType("int");

                    b.Property<int>("Id_catg")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nomb_prod")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("prec_prod")
                        .HasColumnType("real");

                    b.Property<int>("stock_prod")
                        .HasColumnType("int");

                    b.HasKey("Id_prod");

                    b.HasIndex("CategoriaId_catg");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Detalle_pedido", b =>
                {
                    b.HasOne("Proyecto_EC1.Entitys.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId_pedido");

                    b.HasOne("Proyecto_EC1.Entitys.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId_prod");

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Pedido", b =>
                {
                    b.HasOne("Proyecto_EC1.Entitys.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId_Cliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Proyecto_EC1.Entitys.Producto", b =>
                {
                    b.HasOne("Proyecto_EC1.Entitys.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId_catg");

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
