using BlazorAppDemo.Model;

namespace BlazorAppDemo.Logic
{
    public interface IService
    {
        IEnumerable<Activity> GetActivities();
    }
}
