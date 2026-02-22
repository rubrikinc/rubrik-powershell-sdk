### GetSqlServerSetupScriptsReqBulk
Request parameters for generating the setup script for multiple SQL Server
MI database workloads. This setup script can be downloaded via Managed
Backup Credentials flow.

- accountId: System.String
  - Customer account id on RSC.
- databaseIds: list of System.Strings
  - The database_ids is the list of database ids for which the script is
needed. Each database_id correspond to the rubrik id of the database
workload.
