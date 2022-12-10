// FailoverClusterAppSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region FailoverClusterAppSummary
    public class FailoverClusterAppSummary: IFragment
    {
        #region members
        //      C# -> System.String? FailoverClusterName
        // GraphQL -> failoverClusterName: String (scalar)
        [JsonProperty("failoverClusterName")]
        public System.String? FailoverClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
        // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
        [JsonProperty("failoverClusterAppConfig")]
        public FailoverClusterAppConfig? FailoverClusterAppConfig { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterAppConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        [JsonProperty("operatingSystemType")]
        public FailoverClusterOsType? OperatingSystemType { get; set; }

        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignment? SlaAssignment { get; set; }

        #endregion

    #region methods

    public FailoverClusterAppSummary Set(
        System.String? FailoverClusterName = null,
        System.String? Id = null,
        System.String? PrimaryClusterId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        FailoverClusterAppConfig? FailoverClusterAppConfig = null,
        SlaAssignable? SlaAssignable = null,
        FailoverClusterAppConnectionStatus? ConnectionStatus = null,
        FailoverClusterOsType? OperatingSystemType = null,
        SlaAssignment? SlaAssignment = null
    ) 
    {
        if ( FailoverClusterName != null ) {
            this.FailoverClusterName = FailoverClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( FailoverClusterAppConfig != null ) {
            this.FailoverClusterAppConfig = FailoverClusterAppConfig;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? FailoverClusterName
            // GraphQL -> failoverClusterName: String (scalar)
            if (this.FailoverClusterName != null)
            {
                 s += ind + "failoverClusterName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
            // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
            if (this.EffectiveSlaHolder != null)
            {
                 s += ind + "effectiveSlaHolder\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaHolder.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
            // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
            if (this.FailoverClusterAppConfig != null)
            {
                 s += ind + "failoverClusterAppConfig\n";

                 s += ind + "{\n" + 
                 this.FailoverClusterAppConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

            }
            //      C# -> FailoverClusterOsType? OperatingSystemType
            // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            //      C# -> SlaAssignment? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignment (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FailoverClusterName
            // GraphQL -> failoverClusterName: String (scalar)
            if (this.FailoverClusterName == null && Exploration.Includes(parent + ".failoverClusterName$"))
            {
                this.FailoverClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
            // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
            if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
            {
                this.EffectiveSlaHolder = new EffectiveSlaHolder();
                this.EffectiveSlaHolder.ApplyExploratoryFragment(parent + ".effectiveSlaHolder");
            }
            //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
            // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
            if (this.FailoverClusterAppConfig == null && Exploration.Includes(parent + ".failoverClusterAppConfig"))
            {
                this.FailoverClusterAppConfig = new FailoverClusterAppConfig();
                this.FailoverClusterAppConfig.ApplyExploratoryFragment(parent + ".failoverClusterAppConfig");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
            //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus$"))
            {
                this.ConnectionStatus = new FailoverClusterAppConnectionStatus();
            }
            //      C# -> FailoverClusterOsType? OperatingSystemType
            // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new FailoverClusterOsType();
            }
            //      C# -> SlaAssignment? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignment (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignment();
            }
        }


    #endregion

    } // class FailoverClusterAppSummary
    #endregion

    public static class ListFailoverClusterAppSummaryExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<FailoverClusterAppSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FailoverClusterAppSummary> list, 
            String parent = "")
        {
            var item = new FailoverClusterAppSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types