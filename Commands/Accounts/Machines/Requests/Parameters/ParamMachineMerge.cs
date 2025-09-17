using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Machine"/>.
	/// </summary>
	public class ParamMachineMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Machine"/> you want to update.
		/// </summary>
		public string key;
		/// <summary>
		/// A flag to either remove, or generate a new <see cref="Machine.secret"/>.
		/// </summary>
		public bool? secret;
		/// <summary>
		/// The company to which this <see cref="Machine"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Human friendly name for this <see cref="Machine"/>.
		/// </summary>
		public string nickname;
		/// <summary>
		/// Notes about this <see cref="Machine"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Indicates whether system access is disable.
		/// </summary>
		public bool? enabled;
		/// <summary>
		/// An optional timestamp that restricts this <see cref="Machine"/> from being used before the given date.
		/// </summary>
		public DateTime? notBefore;
		/// <summary>
		/// An optional timestamp that restricts this <see cref="Machine"/> from being used after the given date.
		/// </summary>
		public DateTime? notAfter;

		/// <summary>
		/// The <see cref="Machine"/>'s local timezone.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public TimeZoneInfo timezone;
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		public string language;
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		public Dictionary<string, string> formats;
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		public Dictionary<string, SystemsOfUnits?> measurements;
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		public Dictionary<string, string> options;

		/// <summary>
		/// A list of <see cref="MachineGroup"/> to which this <see cref="Machine"/> belongs.
		/// </summary>
		public List<ulong> groups;
		/// <summary>
		/// Individual permission rules which override the <see cref="MachineGroup"/> rules.
		/// </summary>
		public List<ParamPermission> permissions;
		/// <summary>
		/// List of Fleet Freedom service URIs that this <see cref="Machine"/> is permitted to access.
		/// </summary>
		public List<Uri> services;
		/// <summary>
		/// Optional list of your managed domains from which this <see cref="Machine"/> can be used.
		/// </summary>
		public List<Uri> referrers;
		/// <summary>
		/// Restrict <see cref="Machine"/> access to only the provided IPv4 ranges (using CIDR slash-notation).
		/// </summary>
		public List<string> ipRanges;
		/// <summary>
		/// Indicates whether completely insecure/unrestricted system access is allowed.
		/// </summary>
		public bool? insecure;
	}
}