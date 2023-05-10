// SchemaMeta.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Rubrik.SecurityCloud.Types
{
    public class SchemaMeta
    {
        public static string GraphqlSchemaVersion = "v20230426-26" ;

        public static HashSet<string> UnionMembership( string typeName )
        {
            var UnionMembershipDict = new Dictionary<string, HashSet<string>> {
                { "TimeRangeWithUnit", new HashSet<string> {
                    "PolarisSnapshotGroupByInfo",
                    "AnomalyResultGroupByInfo",
                    "TaskDetailGroupByInfo",
                    "MosaicSnapshotGroupByInfo",
                    "ClusterGroupByInfo",
                    "SnappableGroupByInfo",
                    "CdmSnapshotGroupByInfo",
                    "ClusterMetricGroupByInfo",
                    "MongoSnapshotGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "ManagedVolumeQueuedSnapshotGroupByInfo",
                    "MissedSnapshotGroupByInfo",
                    }
                },
                { "Cluster", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    }
                },
                { "Snappable", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    }
                },
                { "AnomalyStatus", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                { "ActivitySeverityLevel", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                { "Status", new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                { "TaskDetailClusterType", new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                { "TaskDetailObjectType", new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                { "ClusterType", new HashSet<string> {
                    "SnappableGroupByInfo",
                    "ClusterGroupByInfo",
                    }
                },
                { "AzureSnappableLocation", new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                { "CdmSnappableLocation", new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                { "WorkloadLocation", new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                { "ComplianceStatus", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "ProtectionStatus", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "ObjectType", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "ClusterSlaDomain", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "SnappableChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "ActivityChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "InfrastructureChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "AnomalyChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "FailoverChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "UserAuditChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "TaskDetailChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "TaskSummaryChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SonarReportChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SonarContentReportChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SnappableTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "ActivityTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "InfrastructureTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "AnomalyTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "FailoverTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "UserAuditTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "TaskDetailTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "TaskSummaryTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "SonarReportTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "SonarContentReportTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
            };
            if (UnionMembershipDict.TryGetValue(typeName, out var unionNames))
            {
                return unionNames;
            }
            return new HashSet<string>();
        }
    }
}