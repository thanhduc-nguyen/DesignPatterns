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

var bluePrintBuilder = new BluePrintBuilder();
director.Builder = bluePrintBuilder;
director.BuildABluePrint();
var bluePrint1 = bluePrintBuilder.GetBluePrint();
bluePrint1.GetInformation();

// Builder not using Director
var castleBuilder = new CastleBuilder();
castleBuilder.BuildRooms(20);
castleBuilder.BuildFancyStatues();
castleBuilder.BuildGarden();
var castle1 = castleBuilder.GetArchitecture();
castle1.ShowOff();
