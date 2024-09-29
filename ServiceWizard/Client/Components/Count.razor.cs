using Microsoft.AspNetCore.Components;


namespace ServiceWizard.Client.Components
{
    public partial class Count: ComponentBase
    {
        [Inject]
        private ITestService tService { get; set; }

        private int currentCount = 0;
        private bool isFailed = false;
        private string? exMessage = "";
        private void IncrementCount()
        {
            tService.RaiseValue();
            currentCount = tService.Counter;
            try
            {
                CheckIfCanRaise();
            }
            catch (Exception e)
            {
                isFailed = true;
                exMessage = e.Message;
            }
        }
        private void ResetCount()
        {
            tService.Counter = 0;
            currentCount = tService.Counter;
            isFailed = false;
        }
        private void CheckIfCanRaise()
        {
            if (currentCount > 5)
            {
                throw new InvalidOperationException("count nie może być większy niż 5!");
            }
        }
    }
}
