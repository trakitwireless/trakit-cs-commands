using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="MaintenanceJob"/>.
	/// </summary>
	public class ParamMaintenanceJobMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="MaintenanceJob"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="MaintenanceJob"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The identifier of the <see cref="Asset"/> to which this <see cref="MaintenanceJob"/> is assigned.
		/// </summary>
		/// <override required="create" />
		public ulong? asset;
		/// <summary>
		/// The <see cref="MaintenanceSchedule"/> from which this job was created
		/// </summary>
		/// <seealso cref="MaintenanceSchedule.id" />
		public ulong? schedule;
		/// <summary>
		/// The work being done. Like "oil change".
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes about the <see cref="MaintenanceJob"/>.  Like "changed the oil and filter".
		/// </summary>
		public string notes;
		/// <summary>
		/// The status of this <see cref="MaintenanceJob"/>.
		/// </summary>
		public MaintenanceJobStatus? status;
		/// <summary>
		/// When was this <see cref="MaintenanceJob"/> created.
		/// </summary>
		/// <override value="current time" />
		public DateTime? created;
		/// <summary>
		/// When was this <see cref="MaintenanceJob"/> created.
		/// </summary>
		public DateTime? completed;
		/// <summary>
		/// The odometer at the time of the service.
		/// </summary>
		public double? odometer;
		/// <summary>
		/// The operating time at the time of the service.
		/// </summary>
		public double? engineHours;

		// ------------ repair details ------------
		/// <summary>
		/// The name of the garage or service facility where the work is done.
		/// </summary>
		/// <override max-length="100" />
		public string garage;
		/// <summary>
		/// Time it took to complete the <see cref="MaintenanceJob"/>.
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// How much the <see cref="MaintenanceJob"/> cost in dollars.
		/// </summary>
		public double? cost;
		/// <summary>
		/// A reference code used to track this <see cref="MaintenanceJob"/>.
		/// </summary>
		/// <override max-length="100" />
		public string reference;
		/// <summary>
		/// The mechanic who performed the work.
		/// </summary>
		/// <override max-length="100" />
		public string technician;
		/// <summary>
		/// <see cref="Picture"/>s taken while performing the work for reference.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public List<ulong> pictures;
	}
}