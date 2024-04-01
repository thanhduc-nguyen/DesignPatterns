namespace ChainOfResponsibility
{
    /// <summary>
    /// Handler.
    /// </summary>
    public interface IHandler<TIn, TOut>
    {
        int Order { get; }
        void SetNext(IHandler<TIn, TOut> handler);
        TOut Handle(TIn input, TOut result);
    }

    /// <summary>
    /// Base Handler.
    /// </summary>
    public abstract class BaseHandler<TIn, TOut> : IHandler<TIn, TOut>
    {
        protected IHandler<TIn, TOut>? next;
        public abstract int Order { get; }

        public void SetNext(IHandler<TIn, TOut> next)
        {
            this.next = next;
        }

        public abstract TOut Handle(TIn info, TOut result);
    }

    public class Info
    {
        public string Information { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    /// <summary>
    /// Concrete Class.
    /// </summary>
    public class AddId : BaseHandler<Person, Info>
    {
        public override int Order => 1;

        public override Info Handle(Person person, Info result)
        {
            result.Information += $"{person.Id} ";
            return next != null ? next.Handle(person, result) : new Info();
        }
    }

    /// <summary>
    /// Concrete Class.
    /// </summary>
    public class AddName : BaseHandler<Person, Info>
    {
        public override int Order => 2;

        public override Info Handle(Person person, Info result)
        {
            result.Information += $"{person.Name} ";
            return next != null ? next.Handle(person, result) : new Info();
        }
    }

    /// <summary>
    /// Concrete Class.
    /// </summary>
    public class AddGender : BaseHandler<Person, Info>
    {
        public override int Order => 3;

        public override Info Handle(Person person, Info result)
        {
            result.Information += $"{person.Gender} ";
            return next != null ? next.Handle(person, result) : new Info();
        }
    }
}