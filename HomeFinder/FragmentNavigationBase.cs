﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace HomeFinder
{
    public class FragmentNavigationBase : ComponentBase, IDisposable
    {
        [Inject] NavigationManager NavManager { get; set; }
        [Inject] IJSRuntime JsRuntime { get; set; }

        protected override void OnInitialized()
        {
            NavManager.LocationChanged += TryFragmentNavigation;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await NavManager.NavigateToFragmentAsync(JsRuntime);
            }
        }

        private async void TryFragmentNavigation(object sender, LocationChangedEventArgs args)
        {
            if (args.Location != string.Empty)
            {
                await NavManager.NavigateToFragmentAsync(JsRuntime);
            }
        }

        public void Dispose()
        {
            NavManager.LocationChanged -= TryFragmentNavigation;
        }
    }
}
