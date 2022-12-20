using CommandLine;

namespace SE_Master.CLI
{
	public abstract class BasicAction : IAction
	{
		[Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
		public bool Verbose { get; set; } = false;
		[Option('f', "force", Required = false, HelpText = "Force the zip operation")]
		public bool Force { get; set; } = false;

		public abstract ActionResult Execute();
	}
}
