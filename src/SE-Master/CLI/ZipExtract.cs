using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEMaster.FileFormats;

namespace SE_Master.CLI
{
	[Verb("extract", HelpText = "Extract all contents of a zip")]
	public class ZipExtract : ZipAction
	{
		public override void RunAction()
		{
			XZP2Pack pack = new(File.OpenRead(ZipName));
			base.RunAction();

			foreach (var zipEntry in pack.ZipEntries.Values)
			{
				Console.
			}

			return;
		}
	}
}
