using CommandLine;
using SE_Master.CLI;

namespace SE_Master
{
	internal static class Program
	{

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var cmdArgs = Environment.GetCommandLineArgs();

			if (cmdArgs.Length > 1)
			{
				// command line args were parsed. init CLI mode
				Parser.Default.ParseArguments<ZipBuildOpts>(cmdArgs)
					.MapResult(
					  (AddOptions opts) => RunAddAndReturnExitCode(opts)
					  errs => 1);
			}
			else
			{
				// gui mode
				ApplicationConfiguration.Initialize();
				Application.Run(new SEMaster());
			}
		}
	}
}