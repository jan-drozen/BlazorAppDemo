using BlazorAppDemo.Model;

namespace BlazorAppDemo.Logic
{
    public class InMemoryActivityService : IActivityService
    {
        public InMemoryActivityService()
        {

        }

        public IEnumerable<Activity> GetActivities()
        {
            return new[] { new Activity() { Name = "Activity 1" }, new Activity() { Name = "Activity 2" } };
        }
    }
}
