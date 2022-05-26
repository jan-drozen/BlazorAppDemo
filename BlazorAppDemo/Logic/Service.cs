using BlazorAppDemo.Model;

namespace BlazorAppDemo.Logic
{
    public class Service : IService
    {
        private IActivityService activityService;
        public Service(IActivityService activityService)
        {
            this.activityService = activityService;
        }

        public IEnumerable<Activity> GetActivities()
        {
            return activityService.GetActivities();
        }
    }
}
