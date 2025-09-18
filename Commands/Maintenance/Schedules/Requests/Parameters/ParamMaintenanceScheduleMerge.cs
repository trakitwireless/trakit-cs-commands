using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="MaintenanceSchedule"/>.
	/// </summary>
	public class ParamMaintenanceScheduleMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="MaintenanceSchedule"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="MaintenanceSchedule"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public string notes;

		/// <summary>
		/// Which <see cref="Asset"/>s are targetted by this <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public string targets;
		/// <summary>
		/// List of Users to send notifications.
		/// </summary>
		/// <see cref="User.login" />
		public List<string> notify;

		/// <summary>
		/// The fill/background colour of the icon.  Should be a hex colour in the format #RRGGBB.
		/// </summary>
		public string fill;
		/// <summary>
		/// Outline and graphic colour.  Should be a hex colour in the format #RRGGBB.
		/// </summary>
		public string stroke;
		/// <summary>
		/// The name of the symbol for this report.
		/// </summary>
		public string graphic;

		/// <summary>
		/// The number of days in advance to predict a <see cref="MaintenanceJob"/> will become pending.
		/// </summary>
		public uint? predictionDays;
		/// <summary>
		/// The number of days between service visits.
		/// </summary>
		public uint? recurDays;
		/// <summary>
		/// The amount of mileage between service visits.
		/// </summary>
		public double? recurDistance;
		/// <summary>
		/// The number of operating hours between service visits.
		/// </summary>
		public double? recurEngineHours;
		/// <summary>
		/// The per-<see cref="Asset"/> details calculated by the system to help predict the creation of <see cref="MaintenanceJob"/>s.
		/// </summary>
		public Dictionary<ulong, MaintenanceRecurrence> intervals;

		// ------------ repair details ------------
		/// <summary>
		/// The name of the garage or service facility where the work is done.
		/// </summary>
		public string garage;
		/// <summary>
		/// The estimated time for the created <see cref="MaintenanceJob"/>.
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// The estimated cost for the created <see cref="MaintenanceJob"/> cost in dollars.
		/// </summary>
		public double? cost;
		/// <summary>
		/// A reference code used to track this created <see cref="MaintenanceJob"/>.
		/// </summary>
		public string reference;
	}
}