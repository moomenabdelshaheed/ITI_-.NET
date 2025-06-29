using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDay02.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthorId", "CatId", "DateTime", "Description", "Title", "bref" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latest developments in AI and how it changes the world.", "AI Breakthrough", "New AI tech" },
                    { 2, 2, 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Top wellness trends you need to know.", "Healthy Living", "Wellness trends" },
                    { 3, 3, 3, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "An overview of the stock market and projections.", "Stock Market Insights", "Market analysis" },
                    { 4, 4, 4, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "New reforms in the education system.", "Education Reforms", "System updates" },
                    { 5, 1, 1, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "How AI and automation are impacting jobs.", "Future of Tech Jobs", "Career advice" },
                    { 6, 2, 2, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding mental health in modern society.", "Mental Health Awareness", "Mind matters" },
                    { 7, 3, 3, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to invest safely in cryptocurrency.", "Crypto Investment Tips", "Digital finance" },
                    { 8, 4, 4, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comparison between top online education platforms.", "Online Learning Platforms", "E-learning" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
