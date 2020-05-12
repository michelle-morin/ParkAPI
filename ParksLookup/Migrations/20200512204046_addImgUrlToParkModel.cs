using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class addImgUrlToParkModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Parks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://www.doi.gov/sites/doi.gov/files/uploads/ZionNPTomMorrisSmall.jpg");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://qtxasset.com/styles/breakpoint_xl_880px_w/s3/2016-12/grandcanyon.jpg?2H48iWIbdwFXJONyIv3sifQ56hHpCBao&itok=WXNiTjRE");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://www.nps.gov/crla/planyourvisit/images/crater-lake-in-summer-4a-smaller_2.jpg");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "ImgUrl",
                value: "https://kval.com/resources/media/a89b1f7d-ec51-4562-9357-0acecd06a98d-large16x9_24.CraterLakeNationalPark.jpg?1531428301707");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "ImgUrl",
                value: "https://www.fossilguy.com/sites/calvert/cliffs_2010.jpg");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ImgUrl",
                value: "https://www.audubon.org/sites/default/files/styles/hero_image/public/death-valley.jpg?itok=LFDW7UEh");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "ImgUrl",
                value: "https://media1.fdncms.com/bend/imager/u/blog/4036890/smithrock-a2b55429a232be03.jpg?cb=1563788413");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                column: "ImgUrl",
                value: "https://d3qvqlc701gzhm.cloudfront.net/thumbs/c0b3cf530efd2a8a163d44c8b9ae3e2bd6047978563bcc887bd5c8dbeac26b70-750.jpg");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                column: "ImgUrl",
                value: "https://lh5.ggpht.com/-I-mqCC6kWvE/UxiCSjUyRgI/AAAAAAAAwiY/oID2F-tuTps/painted-hills-15%25255B6%25255D.jpg?imgmax=800");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                column: "ImgUrl",
                value: "https://www.destination360.com/north-america/us/washington/san-juan-islands/images/s/moran-state-park-orcas-island.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Parks");
        }
    }
}
