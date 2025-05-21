namespace Trakit.Commands {
	/// <summary>
	/// A container for the id, script id, and owning <see cref="Company.id"/> of the object requested/created.
	/// </summary>
	public class ContentIdScript : ContentIdCompany {
		/// <summary>
		/// Identifier of the script to which this object belongs.
		/// </summary>
		public ulong script;
	}
}