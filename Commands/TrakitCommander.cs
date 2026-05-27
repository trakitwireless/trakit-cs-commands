using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Trakit.Objects;
using Trakit.Tools;

namespace Trakit.Commands {
	/// <summary>
	/// The base class used to help define interaction with all Trak-iT API services.
	/// </summary>
	/// <typeparam name="TClient">.NET class used to communicate over the Internet.</typeparam>
	public abstract class TrakitCommander<TClient> where TClient : IDisposable {
		/// <summary>
		/// Details of the <see cref="User"/> or <see cref="Machine"/> who is connected to the underlying Trak-iT API service.
		/// </summary>
		public RepSelfGet Account { get; protected set; }
		/// <summary>
		/// <see cref="Uri"/> of the underlying Trak-iT API service.
		/// </summary>
		public Uri BaseAddress { get; protected set; }
		/// <summary>
		/// Additional (optional) values added to the query-string of the connection request.
		/// </summary>
		public readonly Dictionary<string, string> Query = new Dictionary<string, string>();
		/// <summary>
		/// Additional (optional) HTTP headers added to the connection request.
		/// </summary>
		public readonly Dictionary<string, string> Headers = new Dictionary<string, string>();

		/// <summary>
		/// Helps to serialize (and deserialize) content when transmitted between this client and the underlying Trak-iT API service.
		/// </summary>
		public readonly TrakitSerializer Serializer = new TrakitSerializer();
		/// <summary>
		/// The underlying client making requests to the Trak-iT API service.
		/// </summary>
		public virtual TClient Client { get; protected set; }

		protected TrakitCommander(Uri baseAddress) {
			this.BaseAddress = baseAddress;
			this.SetAuth();
		}
		public TrakitCommander(RepSelfGet account, Uri baseAddress) : this(baseAddress) {
			this.SetAuth(account);
		}

		/// <summary>
		/// Returns the <see cref="BaseAddress"/> with the appropriate <paramref name="path"/>, <see cref="Query"/> values (and session token if applicable).
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		protected UriBuilder CreateBaseUri(string path = default) {
			var endpoint = new UriBuilder(this.BaseAddress);
			endpoint.Path = path ?? "";
			var query = new Dictionary<string, string>(this.Query);
			if (query.Count > 0) {
				endpoint.Query += "&" + string.Join(
					"&",
					query.Select(p => $"{HttpUtility.UrlEncode(p.Key)}={HttpUtility.UrlEncode(p.Value)}")
				);
			}
			if (endpoint.Query.Length > 1 && endpoint.Query[1] == '&') {
				endpoint.Query = endpoint.Query.Substring(2);
			}
			return endpoint;
		}

		/// <summary>
		/// Sets the authentication context based on the provided account information.
		/// </summary>
		/// <param name="account">An instance of <see cref="RepSelfGet"/> containing the account details.</param>
		public void SetAuth(RepSelfGet account = default)
			=> this.Account = account
						?? new RepSelfGet() {
							errorCode = ErrorCode.unknown,
							message = "Not authenticated.",
						};
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Machine"/>.
		/// </summary>
		/// <param name="machine"></param>
		public void SetAuth(SelfMachine machine) => this.SetAuth(new RepSelfGet() {
			errorCode = ErrorCode.success,
			message = "Authenticated with machine.",
			machine = machine,
		});
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Machine"/>.
		/// </summary>
		/// <param name="machine"></param>
		public void SetAuth(Machine machine) => this.SetAuth(new SelfMachine() {
			key = machine.key,
			secret = machine.secret,
		});
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Session.id"/>.
		/// </summary>
		/// <param name="sessionId"></param>
		public void SetAuth(Guid sessionId) => this.SetAuth(new RepSelfGet() {
			errorCode = ErrorCode.success,
			message = "Authenticated with session token.",
			ghostId = sessionId.ToString(),
		});
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Machine"/>.
		/// </summary>
		/// <param name="sessionId"></param>
		public void SetAuth(string machineKey, string machineSecret) => this.SetAuth(new Machine() {
			key = machineKey,
			secret = machineSecret,
		});

		/// <summary>
		/// Sends a command to the underlying service, and returns a <see cref="Task"/> that completes when a reply is received.
		/// </summary>
		/// <typeparam name="TReply"></typeparam>
		/// <param name="payload"></param>
		/// <returns></returns>
		public abstract Task<TReply> Command<TReply>(Payload payload);
	}
}