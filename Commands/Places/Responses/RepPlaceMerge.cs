namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="place"/>.
	/// </summary>
	public class RepPlaceMerge : Reply {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public ContentIdCompany place;
	}
}