### GetSqlServerSetupScriptsReqBulk
Request parameters for generating the setup script for multiple SQL Server
MI database workloads. This setup script can be downloaded via Managed
Backup Credentials flow.

- serverIds: list of System.Strings
  - The server_ids is the list of server ids for which the script is
needed. Each server id correspond to the rubrik id of the server.
