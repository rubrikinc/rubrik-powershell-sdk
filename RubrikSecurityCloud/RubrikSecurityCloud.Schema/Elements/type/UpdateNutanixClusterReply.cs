// UpdateNutanixClusterReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    #region UpdateNutanixClusterReply
    public class UpdateNutanixClusterReply: IFragment
    {
        #region members
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        [JsonProperty("nutanixClusterSummary")]
        public NutanixClusterSummary? NutanixClusterSummary { get; set; }

        #endregion

    #region methods

    public UpdateNutanixClusterReply Set(
        System.String? CaCerts = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        NutanixClusterSummary? NutanixClusterSummary = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( NutanixClusterSummary != null ) {
            this.NutanixClusterSummary = NutanixClusterSummary;
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
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String! (scalar)
            if (this.CaCerts != null)
            {
                 s += ind + "caCerts\n";

            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

                 s += ind + "{\n" + 
                 this.ConnectionStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NutanixClusterSummary? NutanixClusterSummary
            // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
            if (this.NutanixClusterSummary != null)
            {
                 s += ind + "nutanixClusterSummary\n";

                 s += ind + "{\n" + 
                 this.NutanixClusterSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String! (scalar)
            if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts$"))
            {
                this.CaCerts = new System.String("FETCH");
            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
            {
                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFragment(parent + ".connectionStatus");
            }
            //      C# -> NutanixClusterSummary? NutanixClusterSummary
            // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
            if (this.NutanixClusterSummary == null && Exploration.Includes(parent + ".nutanixClusterSummary"))
            {
                this.NutanixClusterSummary = new NutanixClusterSummary();
                this.NutanixClusterSummary.ApplyExploratoryFragment(parent + ".nutanixClusterSummary");
            }
        }


    #endregion

    } // class UpdateNutanixClusterReply
    #endregion

    public static class ListUpdateNutanixClusterReplyExtensions
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
            this List<UpdateNutanixClusterReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateNutanixClusterReply> list, 
            String parent = "")
        {
            var item = new UpdateNutanixClusterReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types