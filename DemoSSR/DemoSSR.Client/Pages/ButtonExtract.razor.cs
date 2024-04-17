using Microsoft.AspNetCore.Components;

namespace DemoSSR.Client.Pages
{
    public partial class ButtonExtract
    {
        [Parameter]
        public int MyProperty { get; set; }

        [Parameter]
        public EventCallback<int> NotifyParentComponent { get; set; }

        protected override bool ShouldRender()
        {
            return (MyProperty % 10 == 0);
        }
        protected override void OnParametersSet()
        {
            if (ShouldRender())
            {
                MyProperty *= 2;
            }
        }

        public void Notify()
        {
            NotifyParentComponent.InvokeAsync(MyProperty);
        }


    }
}
