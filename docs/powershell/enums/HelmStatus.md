### HelmStatus
Compatibility status between the deployed Helm chart and the running Rubrik CDM.

- OK - The deployed Helm chart and Rubrik CDM versions are compatible.
- STALE_HELM - Deployed Helm chart is older than the running Rubrik CDM requires.
- STALE_CDM - Running Rubrik CDM is older than the deployed Helm chart requires.
- UNKNOWN - Helm status could not be determined. The cluster did not report a recognized status.
