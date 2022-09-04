namespace GenericRepo
{
    public partial class TodoItem
    {
        public Guid Id {get; set;}
        public string Name {get; set;} = default!;
    }
}