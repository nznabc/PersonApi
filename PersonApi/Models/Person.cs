namespace PersonApi.Models
{
    public sealed class Person : BaseEntity
    {
        public string Name { get; set; } = string.Empty; //make it immutable to prevent changing after initializing for the first time

        public string Family { get; set; } = string.Empty;
    }
}
