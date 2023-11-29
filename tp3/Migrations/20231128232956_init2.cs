using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersMembershiptypes");

            migrationBuilder.DropTable(
                name: "GenresMovies");

            migrationBuilder.CreateIndex(
                name: "IX_movies_genre_id",
                table: "movies",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "IX_customers_membershiptype_id",
                table: "customers",
                column: "membershiptype_id");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_membershiptypes_membershiptype_id",
                table: "customers",
                column: "membershiptype_id",
                principalTable: "membershiptypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_genre_id",
                table: "movies",
                column: "genre_id",
                principalTable: "genres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_membershiptypes_membershiptype_id",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_genre_id",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_genre_id",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_customers_membershiptype_id",
                table: "customers");

            migrationBuilder.CreateTable(
                name: "CustomersMembershiptypes",
                columns: table => new
                {
                    MembershiptypesId = table.Column<int>(type: "int", nullable: false),
                    membershiptype_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersMembershiptypes", x => new { x.MembershiptypesId, x.membershiptype_id });
                    table.ForeignKey(
                        name: "FK_CustomersMembershiptypes_customers_membershiptype_id",
                        column: x => x.membershiptype_id,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersMembershiptypes_membershiptypes_MembershiptypesId",
                        column: x => x.MembershiptypesId,
                        principalTable: "membershiptypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenresMovies",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    genre_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenresMovies", x => new { x.GenresId, x.genre_id });
                    table.ForeignKey(
                        name: "FK_GenresMovies_genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenresMovies_movies_genre_id",
                        column: x => x.genre_id,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersMembershiptypes_membershiptype_id",
                table: "CustomersMembershiptypes",
                column: "membershiptype_id");

            migrationBuilder.CreateIndex(
                name: "IX_GenresMovies_genre_id",
                table: "GenresMovies",
                column: "genre_id");
        }
    }
}
