using ChainOfResponsibility;

Console.Title = "Chain of Responsibility";

var handlers = new List<IHandler<Person, Info>>
{
    new AddName(),
    new AddId(),
    new AddGender()
}.OrderBy(x => x.Order).ToList();

var person = new Person
{
    Id = 1,
    Name = "John",
    Gender = "Male"
};
var info = new Info();

var prevHandler = default(IHandler<Person, Info>);
foreach (var handler in handlers)
{
    if (prevHandler == null)
    {
        prevHandler = handler;
    }
    else
    {
        prevHandler.SetNext(handler);
        prevHandler = handler;
    }
}

handlers.First().Handle(person, info);

Console.WriteLine(info.Information);