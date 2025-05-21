using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyDirectorys"/>.
	/// </summary>
	public abstract class RepCompanyDirectoryList : Reply {
		/// <summary>
		/// The list of requested <see cref="CompanyDirectory"/>s.
		/// </summary>
		public CompanyDirectory[] companyDirectorys;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyDirectoryListByCompany : RepCompanyDirectoryList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyDirectoryListByCompanyAndLabels : RepCompanyDirectoryListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectory.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyDirectoryListByCompanyAndRefPairs : RepCompanyDirectoryListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectory.references"/>
		public Dictionary<string, string> references;
	}
}