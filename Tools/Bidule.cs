using Microsoft.JSInterop;

namespace Tools
{
    public class Bidule
    {
        
        public IJSRuntime js { get; set; }
        public Bidule(IJSRuntime _js)
        {
            js = _js;
        }
        public void SuperMethode()
        {
            js.InvokeVoidAsync("console.log", "from service");

        }
    }
}
