using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="dispatchJobs"/>.
	/// </summary>
	public abstract class RepDispatchJobList : Reply {
		/// <summary>
		/// The list of requested <see cref="DispatchJob"/>s.
		/// </summary>
		public DispatchJob[] dispatchJobs;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchJobListByAsset : RepDispatchJobList, IRepListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId asset { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchJobListByAssetAndRefPairs : RepDispatchJobListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchJobListByCompany : RepDispatchJobList, IRepListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchJobListByCompanyAndLabels : RepDispatchJobListByCompany, IRepListByLabels {
		/// <summary>
		/// A list of <see cref="LabelStyle.code">label codes</see> used to match <see cref="DispatchJob"/>s.
		/// All labels must match to include a <see cref="DispatchJob"/> in the result.
		/// </summary>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RepDispatchJobListByCompanyAndRefPairs : RepDispatchJobListByCompany, IRepListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}