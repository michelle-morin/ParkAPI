using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Agency", "Campsites", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "National Park Service", true, "Located in southern Utah near the city of Springdale. The park provides access to varied hiking, canyoneering, and water adventures.", "Zion", "Utah" },
                    { 2, "National Park Service", true, "Truly grand: a steep-sided canyon carved by the Colorado River. The Grand Canyon features layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower.", "Grand Canyon", "Arizona" },
                    { 3, "National Park Service", true, "This volcanic crater is the deepest lake in the United States and ninth-deepest lake in the world. Located in south-central Oregon, Crater Lake  is famous for its deep blue color and water clarity.", "Crater Lake", "Oregon" },
                    { 4, "Portland Parks & Recreation Department", false, "1300 acres of urban forest in Portland, OR, stretching along hillsides overlooking the Willamette River. Great running/hiking trails.", "Forest Park", "Oregon" },
                    { 5, "Maryland Department of Natural Resources (DNR)", false, "Public recreation area in Lusby, Calvert County, Maryland, that protects a portion of cliffs that extend for 24 miles along the eastern flank of the Calvert Peninsula on the west side of Chesapeake Bay from Chesapeake Beach southward to Drum Point. Nice boardwalk for a wooded hike to the beach.", "Calvert Cliffs", "Utah" },
                    { 6, "National Park Service", true, "Hottest, driest, and lowest national park. Death Valley is the largest U.S. National Park outside Alaska at 3.4 million acres. Nearly 1000 miles of paved and dirt roads provide access to locations both popular and remote. 91% of the park is protected as officially designated Wilderness. That wild country includes low valley floors crusted with barren salt flats, rugged mountains rising as much as 11,000 feet, deep and winding canyons, rolling sand dunes, and spring-fed oases.", "Death Valley", "California" },
                    { 7, "Oregon State Parks", true, "Located in central Oregon's high desert near the communities of Redmond and Terrebonne. The park, having several thousand climbs and more than a thousand of whihch are bolted routes, is a haven for rock climbers. Miles of hiking and mountain biking trails also wind through the canyon.", "Smith Rock", "Oregon" },
                    { 8, "Oregon State Parks", true, "Formerly the primary military defense  installation in the three-fort, Harbor Defense System at the mouth of the Columbia River. Now, Fort Stevens is a 4,300-acre park offering a variety of recreational opportunities, including camping, beach-combing, freshwater lake swimming, hiking trails, wildlife viewing and a historic shipwreck.", "Fort Stevens State Park", "Oregon" },
                    { 9, "National Park Service", false, "Part of the John Day Fossil Beds. The painted hills are located about 9 miles northwest of Mitchell, Oregon and distinguished by their stripes of red, tan, orange, and black. If you visit, stay off the dirt to help preserve the monument!", "Painted Hills", "Oregon" },
                    { 10, "Washington State Parks", true, "Public recreation area on Orcas Island in Puget Sound's San Juan Islands. This 5,424-acre park offers abundant camping (151 sites), five freshwater lakes for swimming and non-motorized boating, and more than 30 miles of hiking, bicycling, mountain biking and equestrian trails.", "Moran State Park", "Washington" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
