### CcesProxyConfig
Proxy configuration for proxy-enabled CCES deployments.

- protocol: ProxyProtocol
  - Proxy protocol. Only HTTPS is accepted.
- server: System.String
  - Proxy hostname or routable IP. Internal and cloud-metadata addresses are rejected at validation.
- port: System.Int32
  - Proxy port (1-65535).
- username: System.String
  - Optional proxy username. Its presence indicates an authenticated proxy.
- proxyPasswordSecretRef: CcesProxyPasswordSecretRefInput
  - Reference to the customer-owned proxy password secret,
namespaced by cloud provider. Required when the username is set.
