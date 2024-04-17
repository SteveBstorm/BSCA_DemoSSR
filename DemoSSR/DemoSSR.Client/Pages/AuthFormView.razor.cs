using DemoSSR.Client.Models;
using Microsoft.AspNetCore.Components;

namespace DemoSSR.Client.Pages
{
    public partial class AuthFormView
    {
        [Inject]
        public NavigationManager nav { get; set; }
        public AuthForm MyForm { get; set; } = new AuthForm();

        public void Submit()
        {
            nav.NavigateTo("demo1");
        }
    }
}
