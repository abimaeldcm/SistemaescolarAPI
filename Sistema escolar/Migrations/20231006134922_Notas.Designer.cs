﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_escolar.Data;

namespace Sistema_escolar.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20231006134922_Notas")]
    partial class Notas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema_escolar.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Disciplinas", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrimNota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvaFinal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SegNota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TerNota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Disciplinas", b =>
                {
                    b.HasOne("Sistema_escolar.Models.Aluno", "Aluno")
                        .WithMany("Disciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Nota", b =>
                {
                    b.HasOne("Sistema_escolar.Models.Disciplinas", "Disciplina")
                        .WithMany("Notas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Aluno", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("Sistema_escolar.Models.Disciplinas", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
