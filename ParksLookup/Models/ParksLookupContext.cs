using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Zion", Agency = "National Park Service", State = "Utah", Description = "Located in southern Utah near the city of Springdale. The park provides access to varied hiking, canyoneering, and water adventures.", Campsites = true },
          new Park { ParkId = 2, Name = "Grand Canyon", Agency = "National Park Service", State = "Arizona", Description = "Truly grand: a steep-sided canyon carved by the Colorado River. The Grand Canyon features layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower.", Campsites = true },
          new Park { ParkId = 3, Name = "Crater Lake", Agency = "National Park Service", State = "Oregon", Description = "This volcanic crater is the deepest lake in the United States and ninth-deepest lake in the world. Located in south-central Oregon, Crater Lake  is famous for its deep blue color and water clarity.", Campsites = true },
          new Park { ParkId = 4, Name = "Forest Park", Agency = "Portland Parks & Recreation Department", State = "Oregon", Description = "1300 acres of urban forest in Portland, OR, stretching along hillsides overlooking the Willamette River. Great running/hiking trails.", Campsites = false },
          new Park { ParkId = 5, Name = "Calvert Cliffs", Agency = "Maryland Department of Natural Resources (DNR)", State = "Maryland", Description = "Public recreation area in Lusby, Calvert County, Maryland, that protects a portion of cliffs that extend for 24 miles along the eastern flank of the Calvert Peninsula on the west side of Chesapeake Bay from Chesapeake Beach southward to Drum Point. Nice boardwalk for a wooded hike to the beach.", Campsites = false },
          new Park { ParkId = 6, Name = "Death Valley", Agency = "National Park Service", State = "California", Description = "Hottest, driest, and lowest national park. Death Valley is the largest U.S. National Park outside Alaska at 3.4 million acres. Nearly 1000 miles of paved and dirt roads provide access to locations both popular and remote. 91% of the park is protected as officially designated Wilderness. That wild country includes low valley floors crusted with barren salt flats, rugged mountains rising as much as 11,000 feet, deep and winding canyons, rolling sand dunes, and spring-fed oases.", Campsites = true },
          new Park { ParkId = 7, Name = "Smith Rock", Agency = "Oregon State Parks", State = "Oregon", Description = "Located in central Oregon's high desert near the communities of Redmond and Terrebonne. The park, having several thousand climbs and more than a thousand of whihch are bolted routes, is a haven for rock climbers. Miles of hiking and mountain biking trails also wind through the canyon.", Campsites = true },
          new Park { ParkId = 8, Name = "Fort Stevens State Park", Agency = "Oregon State Parks", State = "Oregon", Description = "Formerly the primary military defense  installation in the three-fort, Harbor Defense System at the mouth of the Columbia River. Now, Fort Stevens is a 4,300-acre park offering a variety of recreational opportunities, including camping, beach-combing, freshwater lake swimming, hiking trails, wildlife viewing and a historic shipwreck.", Campsites = true },
          new Park { ParkId = 9, Name = "Painted Hills", Agency = "National Park Service", State = "Oregon", Description = "Part of the John Day Fossil Beds. The painted hills are located about 9 miles northwest of Mitchell, Oregon and distinguished by their stripes of red, tan, orange, and black. If you visit, stay off the dirt to help preserve the monument!", Campsites = false },
          new Park { ParkId = 10, Name = "Moran State Park", Agency = "Washington State Parks", State = "Washington", Description = "Public recreation area on Orcas Island in Puget Sound's San Juan Islands. This 5,424-acre park offers abundant camping (151 sites), five freshwater lakes for swimming and non-motorized boating, and more than 30 miles of hiking, bicycling, mountain biking and equestrian trails.", Campsites = true }
        );
    }
  }
}