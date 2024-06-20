using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clinics_ClinicId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Clinics_Id",
                table: "DoctorClinic");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Doctors_Id",
                table: "DoctorClinic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorClinic",
                table: "DoctorClinic");

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctors",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DoctorClinic",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clinics",
                newName: "ClinicId");

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "DoctorClinic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PatinetId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorClinic",
                table: "DoctorClinic",
                columns: new[] { "ClinicId", "DoctorId" });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "ClinicId",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Warszawa", "Clinic 3" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Age", "Gender", "Major", "Name", "OwnerId", "Surname" },
                values: new object[,]
                {
                    { 1, 26, "Male", "Kardiolog", "Damian 1", null, "Jankowski" },
                    { 2, 60, "Male", "Chirurg", "Kacper 2", null, "Kowalski" },
                    { 3, 34, "Male", "Ortopeda", "Damiano 3", null, "Warszawa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinic_DoctorId",
                table: "DoctorClinic",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clinics_ClinicId",
                table: "Appointments",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Clinics_DoctorId",
                table: "DoctorClinic",
                column: "DoctorId",
                principalTable: "Clinics",
                principalColumn: "ClinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Doctors_ClinicId",
                table: "DoctorClinic",
                column: "ClinicId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clinics_ClinicId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Clinics_DoctorId",
                table: "DoctorClinic");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Doctors_ClinicId",
                table: "DoctorClinic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorClinic",
                table: "DoctorClinic");

            migrationBuilder.DropIndex(
                name: "IX_DoctorClinic_DoctorId",
                table: "DoctorClinic");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "DoctorClinic");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "DoctorClinic",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Clinics",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatinetId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorClinic",
                table: "DoctorClinic",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Bialystok", "Clinic 2" });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 3, "Warszawa", "Clinic 3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clinics_ClinicId",
                table: "Appointments",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Clinics_Id",
                table: "DoctorClinic",
                column: "Id",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Doctors_Id",
                table: "DoctorClinic",
                column: "Id",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
