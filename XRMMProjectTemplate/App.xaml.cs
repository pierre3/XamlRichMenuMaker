using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace XamlRichMenuMaker
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if(e.Args.Length < 2)
            {
                throw new ArgumentException("Command line arguments \"channel access token\" and \"debug user ID\" are required.");
            }

            Properties.Add("ChannelAccessToken", e.Args[0]);
            Properties.Add("UserId", e.Args[1]);

            base.OnStartup(e);
        }
    }
}
