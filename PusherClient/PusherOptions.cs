namespace PusherClient
{
    /// <summary>
    /// The Options to set up the connection with <see cref="Pusher"/>
    /// </summary>
    public class PusherOptions
    {
        private string _host = null;

        /// <summary>
        /// Gets or sets whether the connection will be encrypted
        /// </summary>
        public bool Encrypted { get; set; } = false;

        /// <summary>
        /// Gets or set the Authorizer to use
        /// </summary>
        public IAuthorizer Authorizer { get; set; } = null;

        /// <summary>
        /// Gets or sets the Cluster to user for the Host
        /// </summary>
        public string Cluster { get; set; } = "mt1";

        public string Host {
            get {
                if (_host == null || _host.Length == 0) {
                    _host = $"ws-{Cluster}.pusher.com";
                }

                return _host;
            }

            set {
                _host = value;
            }
        }
    }
}