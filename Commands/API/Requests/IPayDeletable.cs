namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public interface IPayDeletable {
		/// <summary>
		/// When true, the command will also return deleted objects.
		/// </summary>
		bool includeDeleted { get; set; }
	}
}