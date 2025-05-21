using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="users"/>.
	/// </summary>
	public abstract class RepUserList : Reply {
		/// <summary>
		/// The list of requested <see cref="User"/>s.
		/// </summary>
		public User[] users;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepUserListByCompany : RepUserList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}