namespace Prototype.RefactoringGuru
{
    public class Robot : IClone
    {
        public int Id { get; private set; }
        public Infomation Infomation { get; private set; }

        public Robot(int id, Infomation info)
        {
            Id = id;
            Infomation = info;
        }

        public Robot(Robot robot)
        {
            Id = robot.Id++;
            Infomation = new Infomation
            {
                Name = robot.Infomation.Name,
                Brand = robot.Infomation.Brand
            };
        }

        public IClone Clone()
        {
            return new Robot(this);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Robot Id: {Id}, Name: {Infomation.Name}, Created: {Infomation.Brand}");
        }
    }

    public class Infomation
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
