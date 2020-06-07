namespace CourseProject.Menu.Interfaces
{
    interface IAggregate
    {
        IMenuItemIterator GetIterator();
        MenuItem this[int itemIndex] { get; set; }
        int Count { get; }
    }
}
