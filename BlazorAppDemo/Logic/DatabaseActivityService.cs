using BlazorAppDemo.Model;

namespace BlazorAppDemo.Logic
{
    public class DatabaseActivityService : IActivityService
    {
        public IEnumerable<Activity> GetActivities()
        {
            return new[] { new Activity() { Name = "Database Activity 1" }, new Activity() { Name = "Database Activity 2" } };
        }
    }
}
