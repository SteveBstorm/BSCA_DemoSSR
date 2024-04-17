
using Microsoft.AspNetCore.Components;

namespace DemoSSR.Client.Pages
{
    public partial class Demo2
    {
        List<string> items { get; set; }

        [Parameter]
        public int count { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {
            items = new List<string>();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            
            if(items.Count < count)
            {
                items.Add(Guid.NewGuid().ToString());
                StateHasChanged();
                Thread.Sleep(250);
            }
            
        }
        

    } 
}
