using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batteries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batteries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CameraTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisplayQualityes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayQualityes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    HasFlashDrive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Os",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Version = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Os", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    CameraTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cameras_CameraTypes_CameraTypeId",
                        column: x => x.CameraTypeId,
                        principalTable: "CameraTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Size = table.Column<float>(type: "real", nullable: false),
                    DisplayQualityId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Displays_DisplayQualityes_DisplayQualityId",
                        column: x => x.DisplayQualityId,
                        principalTable: "DisplayQualityes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    BatteryId = table.Column<Guid>(type: "uuid", nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayId = table.Column<Guid>(type: "uuid", nullable: false),
                    CpuId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CameraId = table.Column<Guid>(type: "uuid", nullable: false),
                    SimTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    OsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CpuId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Batteries_BatteryId",
                        column: x => x.BatteryId,
                        principalTable: "Batteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Cameras_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Cameras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Cpus_CpuId1",
                        column: x => x.CpuId1,
                        principalTable: "Cpus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Phones_Displays_DisplayId",
                        column: x => x.DisplayId,
                        principalTable: "Displays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Os_OsId",
                        column: x => x.OsId,
                        principalTable: "Os",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_SimTypes_SimTypeId",
                        column: x => x.SimTypeId,
                        principalTable: "SimTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneConnector",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneId = table.Column<Guid>(type: "uuid", maxLength: 100, nullable: false),
                    ConnectorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneConnector", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneConnector_Connectors_ConnectorId",
                        column: x => x.ConnectorId,
                        principalTable: "Connectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneConnector_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_CameraTypeId",
                table: "Cameras",
                column: "CameraTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Displays_DisplayQualityId",
                table: "Displays",
                column: "DisplayQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneConnector_ConnectorId",
                table: "PhoneConnector",
                column: "ConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneConnector_PhoneId",
                table: "PhoneConnector",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_BatteryId",
                table: "Phones",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_BrandId",
                table: "Phones",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CameraId",
                table: "Phones",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CpuId",
                table: "Phones",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CpuId1",
                table: "Phones",
                column: "CpuId1");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_DisplayId",
                table: "Phones",
                column: "DisplayId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_MemoryId",
                table: "Phones",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_OsId",
                table: "Phones",
                column: "OsId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_SimTypeId",
                table: "Phones",
                column: "SimTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneConnector");

            migrationBuilder.DropTable(
                name: "Connectors");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Os");

            migrationBuilder.DropTable(
                name: "SimTypes");

            migrationBuilder.DropTable(
                name: "CameraTypes");

            migrationBuilder.DropTable(
                name: "DisplayQualityes");
        }
    }
}
