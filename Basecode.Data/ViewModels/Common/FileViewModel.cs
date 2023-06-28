namespace Basecode.Data.ViewModels.Common
{
    public class FileViewModel
	{
		public string FileAbsolutePath { get; private set; }
		public string FilePath { get; set; }
		public string NonRelativePath { get; set; }
		public string LocalFileName { get; set; }

		private string _fileName;
		public string FileName {
			get {
				return _fileName;
			}

			set {
				_fileName = value;

				FileAbsolutePath = string.Concat(NonRelativePath, _fileName);
			}
		}
	}
}
