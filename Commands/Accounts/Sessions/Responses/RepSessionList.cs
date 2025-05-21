using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="sessions"/>.
	/// </summary>
	public abstract class RepSessionList : Reply {
		/// <summary>
		/// The list of requested <see cref="Session"/>.
		/// </summary>
		public Session[] sessions;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public abstract class RepSessionListByCompany : RepSessionList {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Company"/> to which the array of <see cref="Session"/>s belong.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// Contains the <see cref="User.login"/> of the collection.
	/// </summary>
	public abstract class RepSessionListByUser : RepSessionList {
		/// <summary>
		/// An object to contain the "login" of the <see cref="User"/> to which the array of <see cref="Session"/>s belong.
		/// </summary>
		public ContentLoginCompany user;
	}
}