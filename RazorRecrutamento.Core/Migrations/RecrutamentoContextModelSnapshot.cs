﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorRecrutamento.Core.Data;

namespace RazorRecrutamento.Core.Migrations
{
    [DbContext(typeof(RecrutamentoContext))]
    partial class RecrutamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorRecrutamento.Core.Model.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataRegistro");

                    b.Property<string>("Descricao");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int?>("VagaId");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("RazorRecrutamento.Core.Model.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("RazorRecrutamento.Core.Model.Candidato", b =>
                {
                    b.HasOne("RazorRecrutamento.Core.Model.Vaga", "Vaga")
                        .WithMany("Candidatos")
                        .HasForeignKey("VagaId");
                });
#pragma warning restore 612, 618
        }
    }
}
