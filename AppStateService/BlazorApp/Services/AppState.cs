namespace BlazorApp.Services
{
    public class AppState
    {
        public AppState()
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
