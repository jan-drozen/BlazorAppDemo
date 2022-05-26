using BlazorAppDemo.Model;

namespace BlazorAppDemo.Logic
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetActivities();
    }
}
