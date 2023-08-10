using System;
using Rhino;
using Rhino.Commands;
using Rhino.UI;

namespace RhinoSamplePlugin
{
    public class SamplePluginCommand : Command
    {
        public SamplePluginCommand()
        {
            var wpfWindow = new SampleWpfWindow();
            var result = Dialogs.ShowSemiModal(wpfWindow);
        }

        public override string EnglishName => "SamplePluginCommand";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
           
            return Result.Success;
        }
    }
}
