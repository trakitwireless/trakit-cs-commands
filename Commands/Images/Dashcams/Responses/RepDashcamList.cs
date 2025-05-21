using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="dashcams"/>.
	/// </summary>
	public abstract class RepDashcamList : Reply {
		/// <summary>
		/// The list of requested <see cref="Dashcam"/>s.
		/// </summary>
		public Dashcam[] dashcams;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepDashcamListByCompany : RepDashcamList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}