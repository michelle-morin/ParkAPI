using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class updateImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "ImgUrl",
                value: "https://res.cloudinary.com/sagacity/image/upload/c_crop,h_1200,w_1600,x_0,y_0/c_limit,dpr_auto,f_auto,fl_lossy,q_80,w_1080/0617-forest-park-stone-house_w82t7g.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "ImgUrl",
                value: "https://kval.com/resources/media/a89b1f7d-ec51-4562-9357-0acecd06a98d-large16x9_24.CraterLakeNationalPark.jpg?1531428301707");
        }
    }
}
