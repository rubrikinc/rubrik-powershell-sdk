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
        public static string GraphqlSchemaVersion = "v20230503-40" ;

        public static HashSet<string> UnionMembership( string typeName )
        {
            var UnionMembershipDict = new Dictionary<string, HashSet<string>> {
                { "ActivityChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "ActivitySeverityLevel", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                { "ActivityTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "AnomalyChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "AnomalyStatus", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                { "AnomalyTable", new HashSet<string> {
                    "ReportTableType",
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
                { "Cluster", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                { "ClusterSlaDomain", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "ClusterType", new HashSet<string> {
                    "ClusterGroupByInfo",
                    "SnappableGroupByInfo",
                    }
                },
                { "ComplianceStatus", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "FailoverChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "FailoverTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "InfrastructureChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "InfrastructureTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "ObjectType", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "ProtectionStatus", new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                { "Snappable", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    }
                },
                { "SnappableChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SnappableTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "SonarContentReportChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SonarContentReportTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "SonarReportChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "SonarReportTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "Status", new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                { "TaskDetailChart", new HashSet<string> {
                    "ReportChartType",
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
                { "TaskDetailTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "TaskSummaryChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "TaskSummaryTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "TimeRangeWithUnit", new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "CdmSnapshotGroupByInfo",
                    "ClusterGroupByInfo",
                    "ClusterMetricGroupByInfo",
                    "ManagedVolumeQueuedSnapshotGroupByInfo",
                    "MissedSnapshotGroupByInfo",
                    "MongoSnapshotGroupByInfo",
                    "MosaicSnapshotGroupByInfo",
                    "PolarisSnapshotGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                { "UserAuditChart", new HashSet<string> {
                    "ReportChartType",
                    }
                },
                { "UserAuditTable", new HashSet<string> {
                    "ReportTableType",
                    }
                },
                { "WorkloadLocation", new HashSet<string> {
                    "SnappableLocationType",
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