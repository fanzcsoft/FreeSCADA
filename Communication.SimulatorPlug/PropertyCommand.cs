﻿using System.Windows.Forms;
using FreeSCADA.ShellInterfaces;

namespace FreeSCADA.Communication.SimulatorPlug
{
	class PropertyCommand: Command
	{
		public PropertyCommand(Plugin plugin)
			: base(plugin, StringConstants.PropertyCommandName, StringConstants.CommunicationGroupName)
		{
		}

		public override void ProcessCommand()
		{
			SettingsForm frm = new SettingsForm(plugin);
			frm.ShowDialog(base.plugin.Environment.MainWindow);
		}
	}
}