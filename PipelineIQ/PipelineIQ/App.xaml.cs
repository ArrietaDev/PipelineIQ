﻿

using PipelineIQ.Pages;

namespace PipelineIQ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new NavigationPage(new OnboardingPage()));
            return window;
        }
    }
}