using CommandLine;

namespace SE_Master.CLI
{
	public class ZipAction : BasicAction
	{
		//=================================================
		// CRACK - Ignore this warning.
		// Construction is done by external library and is an all or nothing instantiation.
		// tldr; null is impossibru
		//==========================================
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		[Option('z', "zip", Required = false, HelpText = "Zip name")]
		public string ZipName { get; set; }
		[Option('d', "dir", Required = false, HelpText = "Working directory name")]
		public string DirectoryName { get; set; }
#pragma warning restore CS8618

		public override ActionResult Execute()
		{
			// make sure zip exists
			if (!File.Exists(ZipName)) throw new FileNotFoundException("Zip not found", ZipName);

			// create if not exists
			if (!Directory.Exists(DirectoryName))
				Directory.CreateDirectory(DirectoryName);
			else if (Directory.GetFiles(DirectoryName).Length > 0 && Force == true)
			{
				// force new if files exist
				Directory.Delete(DirectoryName, true);
				Directory.CreateDirectory(DirectoryName);
			}

			return ActionResult.OK;
		}
	}
}
