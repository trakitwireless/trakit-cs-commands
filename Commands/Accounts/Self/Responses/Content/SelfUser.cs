using System.Collections.Generic;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Similar to the <see cref="User"/> object, but instead of the <see cref="contact"/>
	/// and <see cref="groups"/> properties being identifiers of other objects,
	/// the <see cref="Contact"/> and <see cref="UserGroup"/> objects are embedded within.
	/// </summary>
	public class SelfUser : User {
		/// <summary>
		/// Associated <see cref="Contact"/> information for this user.
		/// </summary>
		new public Contact contact { get; set; }
		/// <summary>
		/// The list of <see cref="UserGroup"/>s to which this <see cref="User"/> belongs.
		/// </summary>
		new public List<UserGroup> groups { get; set; }
		/// <summary>
		/// The <see cref="CompanyPolicy"/> for this <see cref="User"/>'s company.
		/// </summary>
		[JsonProperty("policies")]
		public CompanyPolicy policy { get; set; }
	}
}