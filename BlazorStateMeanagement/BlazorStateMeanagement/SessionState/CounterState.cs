
using System;

namespace BlazorStateManagement.SessionState
{
    public class CounterState
    {
        private int currentCount = 0;

        public event EventHandler StateChanged;

        public int GetCurrentCount()
        {
            return currentCount;
        }
        
        public void SetCurrentCount(int paramCount)
        {
            currentCount = paramCount;
            StateHasChanged();
        }
        
        public void ResetCurrentCount()
        {
            currentCount = 0;
            StateHasChanged();
        }

        private void StateHasChanged()
        {
            // This will update any subscribers
            // that the counter state has changed
            // so they can update themselves
            // and show the current counter value
            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
