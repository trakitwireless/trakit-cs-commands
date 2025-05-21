namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public interface IPaySuspendable {
		/// <summary>
		/// When true, the command will also return suspended objects.
		/// </summary>
		bool includeSuspended { get; set; }
	}
}