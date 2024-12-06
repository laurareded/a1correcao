﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class atualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CriadoEm", "Nome" },
                values: new object[,]
                {
                    { "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", new DateTime(2024, 12, 9, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(2036), "Lazer" },
                    { "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", new DateTime(2024, 12, 8, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(2031), "Estudos" },
                    { "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", new DateTime(2024, 12, 7, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(1677), "Trabalho" }
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[,]
                {
                    { "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e", "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", new DateTime(2024, 12, 9, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(8364), "Preparar-se para a aula de Angular", "Não iniciada", "Estudar Angular" },
                    { "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e", "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", new DateTime(2024, 12, 13, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(7980), "Terminar relatório para reunião", "Não iniciada", "Concluir relatório" },
                    { "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f", "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", new DateTime(2024, 12, 20, 17, 26, 58, 382, DateTimeKind.Local).AddTicks(8368), "Dar um passeio relaxante no parque", "Não iniciada", "Passeio no parque" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e");

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e");

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd");
        }
    }
}