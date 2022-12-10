// ReplicationPairConfigDetails.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    #region ReplicationPairConfigDetails
    public class ReplicationPairConfigDetails: IFragment
    {
        #region members
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        [JsonProperty("setupType")]
        public System.String? SetupType { get; set; }

        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        [JsonProperty("sourceGateway")]
        public GatewayInfo? SourceGateway { get; set; }

        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        [JsonProperty("targetGateway")]
        public GatewayInfo? TargetGateway { get; set; }

        #endregion

    #region methods

    public ReplicationPairConfigDetails Set(
        System.String? SetupType = null,
        GatewayInfo? SourceGateway = null,
        GatewayInfo? TargetGateway = null
    ) 
    {
        if ( SetupType != null ) {
            this.SetupType = SetupType;
        }
        if ( SourceGateway != null ) {
            this.SourceGateway = SourceGateway;
        }
        if ( TargetGateway != null ) {
            this.TargetGateway = TargetGateway;
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
            //      C# -> System.String? SetupType
            // GraphQL -> setupType: String! (scalar)
            if (this.SetupType != null)
            {
                 s += ind + "setupType\n";

            }
            //      C# -> GatewayInfo? SourceGateway
            // GraphQL -> sourceGateway: GatewayInfo (type)
            if (this.SourceGateway != null)
            {
                 s += ind + "sourceGateway\n";

                 s += ind + "{\n" + 
                 this.SourceGateway.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GatewayInfo? TargetGateway
            // GraphQL -> targetGateway: GatewayInfo (type)
            if (this.TargetGateway != null)
            {
                 s += ind + "targetGateway\n";

                 s += ind + "{\n" + 
                 this.TargetGateway.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SetupType
            // GraphQL -> setupType: String! (scalar)
            if (this.SetupType == null && Exploration.Includes(parent + ".setupType$"))
            {
                this.SetupType = new System.String("FETCH");
            }
            //      C# -> GatewayInfo? SourceGateway
            // GraphQL -> sourceGateway: GatewayInfo (type)
            if (this.SourceGateway == null && Exploration.Includes(parent + ".sourceGateway"))
            {
                this.SourceGateway = new GatewayInfo();
                this.SourceGateway.ApplyExploratoryFragment(parent + ".sourceGateway");
            }
            //      C# -> GatewayInfo? TargetGateway
            // GraphQL -> targetGateway: GatewayInfo (type)
            if (this.TargetGateway == null && Exploration.Includes(parent + ".targetGateway"))
            {
                this.TargetGateway = new GatewayInfo();
                this.TargetGateway.ApplyExploratoryFragment(parent + ".targetGateway");
            }
        }


    #endregion

    } // class ReplicationPairConfigDetails
    #endregion

    public static class ListReplicationPairConfigDetailsExtensions
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
            this List<ReplicationPairConfigDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationPairConfigDetails> list, 
            String parent = "")
        {
            var item = new ReplicationPairConfigDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types