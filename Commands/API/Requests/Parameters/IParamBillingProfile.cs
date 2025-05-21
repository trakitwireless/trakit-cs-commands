namespace Trakit.Commands {
	/// <summary>
	/// An interface that when implemented can be used with validator.byBillingProfile.
	/// </summary>
	/// <category>Billing</category>
	public interface IParamBillingProfile {
		ParamId billingProfile { get; set; }
	}
}