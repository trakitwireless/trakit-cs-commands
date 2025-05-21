namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportResult"/>.
	/// </summary>
	public class RepReportResultMerge : Reply {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public ContentIdCompany reportResult;
	}
}