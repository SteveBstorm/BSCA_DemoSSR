using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tools;

namespace DemoSSR.Client.Pages
{
    public partial class Demo1
    {
        
        public string MyProp { get; set; } = "bidule";

        public void test()
        {
            MyProp = "from method";
        }
    }
}
