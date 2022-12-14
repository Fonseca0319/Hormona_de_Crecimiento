// <auto-generated />
using System;
using Hormona.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hormona.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220907010249_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hormona.App.Dominio.Historia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("Hormona.App.Dominio.PatronDeCrecimineto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Pacienteid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("fechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("patronesDeCrecimiento")
                        .HasColumnType("int");

                    b.Property<float?>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("Pacienteid");

                    b.ToTable("Patrones");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sexos")
                        .HasColumnType("int");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Hormona.App.Dominio.SugerenciasDeCiudado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Historiaid")
                        .HasColumnType("int");

                    b.Property<string>("descripcionCiudados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("Historiaid");

                    b.ToTable("sugerencias");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Endocrino", b =>
                {
                    b.HasBaseType("Hormona.App.Dominio.Persona");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endocrino_codigo");

                    b.Property<string>("registro")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endocrino_registro");

                    b.HasDiscriminator().HasValue("Endocrino");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Familiar", b =>
                {
                    b.HasBaseType("Hormona.App.Dominio.Persona");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Familiar");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("Hormona.App.Dominio.Persona");

                    b.Property<int?>("Endocrinoid")
                        .HasColumnType("int");

                    b.Property<int?>("Familiarid")
                        .HasColumnType("int");

                    b.Property<int?>("Historiaid")
                        .HasColumnType("int");

                    b.Property<int?>("Pediatraid")
                        .HasColumnType("int");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaDeNacimineto")
                        .HasColumnType("datetime2");

                    b.Property<float?>("latitud")
                        .HasColumnType("real");

                    b.Property<float?>("longitud")
                        .HasColumnType("real");

                    b.HasIndex("Endocrinoid");

                    b.HasIndex("Familiarid");

                    b.HasIndex("Historiaid");

                    b.HasIndex("Pediatraid");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Pediatra", b =>
                {
                    b.HasBaseType("Hormona.App.Dominio.Persona");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registro")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Pediatra");
                });

            modelBuilder.Entity("Hormona.App.Dominio.PatronDeCrecimineto", b =>
                {
                    b.HasOne("Hormona.App.Dominio.Paciente", null)
                        .WithMany("Patrones")
                        .HasForeignKey("Pacienteid");
                });

            modelBuilder.Entity("Hormona.App.Dominio.SugerenciasDeCiudado", b =>
                {
                    b.HasOne("Hormona.App.Dominio.Historia", null)
                        .WithMany("sugerencias")
                        .HasForeignKey("Historiaid");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Paciente", b =>
                {
                    b.HasOne("Hormona.App.Dominio.Endocrino", "Endocrino")
                        .WithMany()
                        .HasForeignKey("Endocrinoid");

                    b.HasOne("Hormona.App.Dominio.Familiar", "Familiar")
                        .WithMany()
                        .HasForeignKey("Familiarid");

                    b.HasOne("Hormona.App.Dominio.Historia", "Historia")
                        .WithMany()
                        .HasForeignKey("Historiaid");

                    b.HasOne("Hormona.App.Dominio.Pediatra", "Pediatra")
                        .WithMany()
                        .HasForeignKey("Pediatraid");

                    b.Navigation("Endocrino");

                    b.Navigation("Familiar");

                    b.Navigation("Historia");

                    b.Navigation("Pediatra");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Historia", b =>
                {
                    b.Navigation("sugerencias");
                });

            modelBuilder.Entity("Hormona.App.Dominio.Paciente", b =>
                {
                    b.Navigation("Patrones");
                });
#pragma warning restore 612, 618
        }
    }
}
