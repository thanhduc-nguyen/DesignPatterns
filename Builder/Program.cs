using BuilderPattern;

Console.Title = "Builder";


// Builder using Director
var director = new Director();
var houseBuilder = new HouseBuilder();
director.Builder = houseBuilder;

director.BuildAHouseWithGarage();
var house1 = houseBuilder.GetArchitecture();
house1.ShowOff();

director.BuildAHouseWithFullAmenities();
var house2 = houseBuilder.GetArchitecture();
house2.ShowOff();

// Builder not using Director
var castleBuilder = new CastleBuilder();
castleBuilder.BuildRooms(20);
castleBuilder.BuildFancyStatues();
castleBuilder.BuildGarden();
var castle1 = castleBuilder.GetArchitecture();
castle1.ShowOff();
