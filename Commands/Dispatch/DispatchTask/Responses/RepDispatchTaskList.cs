using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="dispatchTasks"/>.
	/// </summary>
	public abstract class RepDispatchTaskList : Reply {
		/// <summary>
		/// The list of requested <see cref="DispatchTask"/>s.
		/// </summary>
		public DispatchTask[] dispatchTasks;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchTaskListByAsset : RepDispatchTaskList, IRepListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId asset { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchTaskListByAssetAndRefPairs : RepDispatchTaskListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchTaskListByCompany : RepDispatchTaskList, IRepListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchTaskListByCompanyAndRefPairs : RepDispatchTaskListByCompany, IRepListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}