using Newtonsoft.Json;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public abstract class PayDispatchJobList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="DispatchJob"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Asset"/>.
	/// </summary>
	public class PayDispatchJobListByAsset : PayDispatchJobList, IPayListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId asset { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Asset"/> only if the specified reference fields match.
	/// If no references are specified, it will match any <see cref="DispatchJob"/> with no references.
	/// If a reference value is null, it will match any <see cref="DispatchJob"/> without that reference key.
	/// </summary>
	public class PayDispatchJobListByAssetAndRefPairs : PayDispatchJobListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class PayDispatchJobListByCompany : PayDispatchJobList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> only if the <see cref="DispatchJob.labels"/> matches all of the given <see cref="labels"/>.
	/// </summary>
	public class PayDispatchJobListByCompanyAndLabels : PayDispatchJobListByCompany, IPayListByLabels {
		/// <summary>
		/// A list of <see cref="LabelStyle.code">label codes</see> used to match <see cref="DispatchJob"/>s.
		/// All labels must match to include a <see cref="DispatchJob"/> in the result.
		/// </summary>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> only if the specified reference fields match.
	/// If no references are specified, it will match any <see cref="DispatchJob"/> with no references.
	/// If a reference value is null, it will match any <see cref="DispatchJob"/> without that reference key.
	/// </summary>
	public class PayDispatchJobListByCompanyAndRefPairs : PayDispatchJobListByCompany, IPayListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> which are not assigned to an <see cref="Asset"/>.
	/// </summary>
	public class PayDispatchJobListByUnassigned : PayDispatchJobListByCompany { }
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> which are not assigned to an <see cref="Asset"/>, only if the <see cref="DispatchJob.labels"/> matches all of the given <see cref="labels"/>.
	/// </summary>
	public class PayDispatchJobListByUnassignedAndLabels : PayDispatchJobListByUnassigned, IPayListByLabels {
		/// <summary>
		/// A list of <see cref="LabelStyle.code">label codes</see> used to match <see cref="DispatchJob"/>s.
		/// All labels must match to include a <see cref="DispatchJob"/> in the result.
		/// </summary>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> which are not assigned to an <see cref="Asset"/>, only if the specified reference fields match.
	/// If no references are specified, it will match any <see cref="DispatchJob"/> with no references.
	/// If a reference value is null, it will match any <see cref="DispatchJob"/> without that reference key.
	/// </summary>
	public class PayDispatchJobListByUnassignedAndRefPairs : PayDispatchJobListByUnassigned, IPayListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}