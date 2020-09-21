using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;

namespace SkeletonExample.Tizen
{
    class Program : FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            MainWindow.IndicatorMode = ElmSharp.IndicatorMode.Hide;
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.Init(app, true);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(app);
            Plugin.MaterialDesignControls.Tizen.Renderer.Init();
            app.Run(args);
        }
    }
}
