namespace CourseProject.Menu.Interfaces
{
    public interface IMenuItemIterator
    {
        MenuItem FirstItem { get; }

        MenuItem NextItem { get; }

        MenuItem CurrentItem { get; }

        bool IsDone { get; }

        int CurrentIndex { get; }
    }
}
