﻿using System;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Miyu.MvxPlugins.TextSelection
{
    [Preserve(AllMembers = true)]
    public class PluginLoader : IMvxPluginLoader
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}
