using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using MAJIKA.GUI;

namespace LuaHost
{
    [MoonSharpUserData]
    public class GUIHost : HostBase
    {
        [MoonSharpHidden]
        public static void InitHost(LuaScriptHost host, Script script)
        {
            script.Globals["gui"] = new GUIHost(host);
            UserData.RegisterProxyType<Proxy.UIPanelProxy<SkillPanel>, SkillPanel>(obj => new Proxy.UIPanelProxy<SkillPanel>(obj, host));
        }
        protected GUIHost(LuaScriptHost host) : base(host)
        {
        }

        public SkillPanel skillPanel
        {
            get => SkillPanel.Instance;
        }
    }
}
