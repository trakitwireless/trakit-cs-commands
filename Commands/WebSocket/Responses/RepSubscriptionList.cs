namespace Trakit.Commands {
	/// <summary>
	/// Gets the list of current subscriptions for your current session.
	/// </summary>
	public class RepSubscriptionList : Reply {
		/// <summary>
		/// The list of your current subscription types.
		/// </summary>
		public Subscription[] subscriptions;
	}
}