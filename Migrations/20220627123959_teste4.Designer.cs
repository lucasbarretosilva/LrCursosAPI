﻿// <auto-generated />
using LrCursosAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LrCursosAPI.Migrations
{
    [DbContext(typeof(LrCursosAPIContext))]
    [Migration("20220627123959_teste4")]
    partial class teste4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LrCursosAPI.Models.Autenticacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit");

                    b.Property<bool>("Liberado")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autenticacao");
                });

            modelBuilder.Entity("LrCursosAPI.Models.Conteudo", b =>
                {
                    b.Property<int>("ConteudoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConteudoId"), 1L, 1);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("TituloAula")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UrlAula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visto")
                        .HasColumnType("bit");

                    b.HasKey("ConteudoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Conteudo");
                });

            modelBuilder.Entity("LrCursosAPI.Models.ConteudoVisto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AutenticacaoId")
                        .HasColumnType("int");

                    b.Property<int>("ConteudoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutenticacaoId");

                    b.HasIndex("ConteudoId");

                    b.ToTable("ConteudoVisto");
                });

            modelBuilder.Entity("LrCursosAPI.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoId"), 1L, 1);

                    b.Property<string>("CursoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visto")
                        .HasColumnType("bit");

                    b.HasKey("CursoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("LrCursosAPI.Models.Conteudo", b =>
                {
                    b.HasOne("LrCursosAPI.Models.Curso", "Curso")
                        .WithMany("Conteudos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("LrCursosAPI.Models.ConteudoVisto", b =>
                {
                    b.HasOne("LrCursosAPI.Models.Autenticacao", "Autenticacao")
                        .WithMany()
                        .HasForeignKey("AutenticacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LrCursosAPI.Models.Conteudo", "Conteudo")
                        .WithMany("ConteudosVistos")
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autenticacao");

                    b.Navigation("Conteudo");
                });

            modelBuilder.Entity("LrCursosAPI.Models.Conteudo", b =>
                {
                    b.Navigation("ConteudosVistos");
                });

            modelBuilder.Entity("LrCursosAPI.Models.Curso", b =>
                {
                    b.Navigation("Conteudos");
                });
#pragma warning restore 612, 618
        }
    }
}