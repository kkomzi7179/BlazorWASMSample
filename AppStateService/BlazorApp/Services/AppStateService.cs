namespace BlazorApp.Services
{
    public class AppStateService
    {
        public AppStateService()
        {
        }
        public bool IsLogin { get; set; }
        public async Task UpdateLoginStatus()
        {
            if (OnUpdateLoginStatus != null)
            {
                await OnUpdateLoginStatus.Invoke();
            }
        }
        public event Func<Task>? OnUpdateLoginStatus;
    }
}
