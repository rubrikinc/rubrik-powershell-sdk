### SapHanaDataPathType
Supported in v6.0+
Data path of the SAP HANA BACKINT interface specifying the location where the BACKINT interface stores backups. Supported data path types are MANAGED_VOLUME, GCP, and LOCAL. MANAGED_VOLUME specifies a data path used by the BACKINT interface to store backups on an on-premises Rubrik CDM cluster. GCP specifies that backups are stored on Google Cloud Platform. LOCAL indicates the backup is stored locally.

- SAP_HANA_DATA_PATH_TYPE_GCP - The type of SAP HANA datapath is GCP.
- SAP_HANA_DATA_PATH_TYPE_LOCAL - The type of SAP HANA datapath is local.
- SAP_HANA_DATA_PATH_TYPE_MANAGED_VOLUME - The type of SAP HANA datapath is Managed Volume.
