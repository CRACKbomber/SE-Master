using CommandLine;
using SEMaster.FileFormats;

namespace SE_Master.CLI
{
	[Verb("extract", HelpText = "Extract all contents of a zip")]
	public class ZipExtract : ZipAction
	{

		public override ActionResult Execute()
		{
			XZP2Pack pack;

			try
			{
				pack = new(File.OpenRead(ZipName));
			}
			catch
			{
				Console.WriteLine("Failed to open zip!");
				throw;
			}

			foreach (var zipEntry in pack.ZipEntries.Values)
			{
				Console.WriteLine(zipEntry.FileName);
			}

			return ActionResult.OK;
		}
	}
}
