using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master.CLI
{
	public abstract class BasicAction : IActionCLI
	{
		[Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
		public bool Verbose { get; set; } = false;
		[Option('f', "force", Required = false, HelpText = "Force the zip operation")]
		public bool Force { get; set; } = false;

		public abstract void RunAction();

		/// <summary>
		/// Simple stub for running a return codeless action
		/// </summary>
		/// <returns></returns>
		public virtual int RunActionExit()
		{
			RunAction();
			return 0;
		}
	}
}
