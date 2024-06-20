using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class final1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Clinics_DoctorId",
                table: "DoctorClinic");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Doctors_ClinicId",
                table: "DoctorClinic");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Clinics_ClinicId",
                table: "DoctorClinic",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "ClinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorClinic_Doctors_DoctorId",
                table: "DoctorClinic",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Clinics_ClinicId",
                table: "DoctorClinic");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorClinic_Doctors_DoctorId",
                table: "DoctorClinic");

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
    }
}
