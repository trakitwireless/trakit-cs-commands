using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create various <see cref="FormFieldType"/>s.
	/// </summary>
	public class ParamFormField : ParamMerge {
		/// <summary>
		/// The identifier of the field.
		/// Identifiers are unique to a <see cref="FormTemplate"/>, but are not unique system-wide.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The name for the field.
		/// </summary>
		public string name;
		/// <summary>
		/// The type of interface control that should be presented to the user.
		/// </summary>
		/// <override required="create" />
		public FormFieldType? kind;
		/// <summary>
		/// Notes or special instructions for this control.
		/// </summary>
		public string notes;
		/// <summary>
		/// When true, a valid value must be given for this field.
		/// </summary>
		public bool? required;
		/// <summary>
		/// The default value for the field in the template.
		/// </summary>
		public string value;
		/// <summary>
		/// When false, this field's value is treated as read-only.
		/// </summary>
		public bool? editable;

		/// <summary>
		/// A <see cref="FormFieldNumeric.size"/> context hint for <see cref="FormFieldNumeric"/> fields.
		/// </summary>
		public FormFieldNumericSize? size;
		/// <summary>
		/// The <see cref="FormFieldNumeric.precision"/> used for <see cref="FormFieldNumeric"/> fields.
		/// </summary>
		public long? precision;
		/// <summary>
		/// The <see cref="FormFieldNumeric.step"/> used for <see cref="FormFieldNumeric"/> fields.
		/// </summary>
		public double? step;
		/// <summary>
		/// The <see cref="FormFieldNumeric.units"/> used for <see cref="FormFieldNumeric"/> fields.
		/// </summary>
		public string units;
		/// <summary>
		/// The <see cref="FormFieldChoice.choices"/> used for <see cref="FormFieldChoice"/> fields.
		/// </summary>
		[JsonIgnore]
		public Dictionary<string, string> choiceDropdown;
		/// <summary>
		/// The <see cref="FormFieldBoolean.choices"/> used for <see cref="FormFieldBoolean"/> fields.
		/// </summary>
		[JsonIgnore]
		public string[] choiceBoolean;
		/// <summary>
		/// The <see cref="FormFieldText.rows"/> used for <see cref="FormFieldText"/> fields.
		/// </summary>
		public long? rows;

		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldAttachments.minimum"/>	as byte
		/// - <see cref="FormFieldChoice.minimum"/>		as byte
		/// - <see cref="FormFieldText.minimum"/>		as ushort
		/// </summary>
		[JsonIgnore]
		public long? minInt;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldAttachments.maximum"/>	as byte
		/// - <see cref="FormFieldChoice.maximum"/>		as byte
		/// - <see cref="FormFieldText.maximum"/>		as ushort
		/// </summary>
		[JsonIgnore]
		public long? maxInt;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldNumeric.minimum"/>		as double
		/// </summary>
		[JsonIgnore]
		public double? minFloat;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldNumeric.maximum"/>		as double
		/// </summary>
		[JsonIgnore]
		public double? maxFloat;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldDate.minimum"/>
		/// </summary>
		[JsonIgnore]
		public DateTime? minDate;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldDate.maximum"/>
		/// </summary>
		[JsonIgnore]
		public DateTime? maxDate;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldTime.minimum"/>
		/// </summary>
		[JsonIgnore]
		public TimeSpan? minTime;
		/// <summary>
		/// Used for:
		/// - <see cref="FormFieldTime.maximum"/>
		/// </summary>
		[JsonIgnore]
		public TimeSpan? maxTime;
		/// <summary>
		/// Will be a <format id="int64" /> or <format id="double" /> representing the minimum number or <see cref="FormFieldAttachments">attachments</see>, <see cref="FormFieldChoice">choices</see>, or shortest <see cref="FormFieldText">text length</see>,
		/// or will be a <format id="datetime"/> representing the earliest possible <see cref="FormFieldDate">date and/or time</see>,
		/// or will be a <format id="datetime"/> representing the earliest possible <see cref="FormFieldTime">time or smallest duration</see>.
		/// Note that dates and times should not be sent assuming it will be converted to UTC, and form fields do not enforce a timezone.
		/// </summary>
		/// <override readonly="false" />
		[JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
		public object _minimum {
			get => this.minInt ?? this.minFloat ?? (object)this.minTime ?? this.minDate;
			set {
				if (value is long minInt) {
					this.minInt = minInt;
					this.minFloat = null;
					this.minDate = null;
					this.minTime = null;
				} else if (value is float minFloat) {
					this.minInt = null;
					this.minFloat = minFloat;
					this.minDate = null;
					this.minTime = null;
				} else if (value is DateTime minDate) {
					this.minInt = null;
					this.minFloat = null;
					this.minDate = minDate;
					this.minTime = null;
				} else if (value is TimeSpan minTime) {
					this.minInt = null;
					this.minFloat = null;
					this.minDate = null;
					this.minTime = minTime;
				}
			}
		}
		/// <summary>
		/// Will be a <format id="int64" /> or <format id="double" /> representing the maximum number or <see cref="FormFieldAttachments">attachments</see>, <see cref="FormFieldChoice">choices</see>, or longest <see cref="FormFieldText">text length</see>,
		/// or will be a <format id="datetime"/> representing the latest possible <see cref="FormFieldDate">date and/or time</see>,
		/// or will be a <format id="datetime"/> representing thee latest possible <see cref="FormFieldTime">time or largest duration</see>.
		/// Note that dates and times should not be sent assuming it will be converted to UTC, and form fields do not enforce a timezone.
		/// </summary>
		/// <override readonly="false" />
		[JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
		public object _maximum {
			get => this.maxInt ?? this.maxFloat ?? (object)this.maxTime ?? this.maxDate;
			set {
				if (value is long maxInt) {
					this.maxInt = maxInt;
					this.maxFloat = null;
					this.maxDate = null;
					this.maxTime = null;
				} else if (value is float maxFloat) {
					this.maxInt = null;
					this.maxFloat = maxFloat;
					this.maxDate = null;
					this.maxTime = null;
				} else if (value is DateTime maxDate) {
					this.maxInt = null;
					this.maxFloat = null;
					this.maxDate = maxDate;
					this.maxTime = null;
				} else if (value is TimeSpan maxTime) {
					this.maxInt = null;
					this.maxFloat = null;
					this.maxDate = null;
					this.maxTime = maxTime;
				}
			}
		}
		/// <summary>
		/// Will be a <see cref="FormFieldChoice.choices">dictionary of strings</see> for choice/drop-down fields,
		/// or will be a <see cref="FormFieldBoolean.choices">array of strings</see> for checkbox/toggle-switch fields.
		/// </summary>
		/// <override readonly="false" />
		[JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
		public object _choices {
			get => this.choiceBoolean ?? (object)this.choiceDropdown;
			set {
				if (value is IEnumerable<string> enumerable) {
					this.choiceBoolean = enumerable?.ToArray();
					this.choiceDropdown = null;
				} else if (value is string[] array) {
					this.choiceBoolean = array;
					this.choiceDropdown = null;
				} else if (value is IDictionary<string, string> pairs) {
					this.choiceBoolean = null;
					this.choiceDropdown = pairs?.ToDictionary(p => p.Key, p => p.Value);
				}
			}
		}
	}
}