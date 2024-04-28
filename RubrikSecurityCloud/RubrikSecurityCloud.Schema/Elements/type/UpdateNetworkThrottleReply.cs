// UpdateNetworkThrottleReply.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpdateNetworkThrottleReply
    public class UpdateNetworkThrottleReply: BaseType
    {
        #region members

        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        [JsonProperty("resourceId")]
        public NetworkThrottleResourceId? ResourceId { get; set; }

        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        [JsonProperty("archivalThrottlePort")]
        public System.Int32? ArchivalThrottlePort { get; set; }

        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        [JsonProperty("defaultThrottleLimit")]
        public System.Single? DefaultThrottleLimit { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        [JsonProperty("networkInterface")]
        public System.String? NetworkInterface { get; set; }

        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        [JsonProperty("scheduledThrottles")]
        public List<NetworkThrottleScheduleSummary>? ScheduledThrottles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateNetworkThrottleReply";
    }

    public UpdateNetworkThrottleReply Set(
        NetworkThrottleResourceId? ResourceId = null,
        System.Int32? ArchivalThrottlePort = null,
        System.Single? DefaultThrottleLimit = null,
        System.Boolean? IsEnabled = null,
        System.String? NetworkInterface = null,
        List<NetworkThrottleScheduleSummary>? ScheduledThrottles = null
    ) 
    {
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ArchivalThrottlePort != null ) {
            this.ArchivalThrottlePort = ArchivalThrottlePort;
        }
        if ( DefaultThrottleLimit != null ) {
            this.DefaultThrottleLimit = DefaultThrottleLimit;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( NetworkInterface != null ) {
            this.NetworkInterface = NetworkInterface;
        }
        if ( ScheduledThrottles != null ) {
            this.ScheduledThrottles = ScheduledThrottles;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        if (this.ArchivalThrottlePort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalThrottlePort\n" ;
            } else {
                s += ind + "archivalThrottlePort\n" ;
            }
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        if (this.DefaultThrottleLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultThrottleLimit\n" ;
            } else {
                s += ind + "defaultThrottleLimit\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        if (this.NetworkInterface != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkInterface\n" ;
            } else {
                s += ind + "networkInterface\n" ;
            }
        }
        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        if (this.ScheduledThrottles != null) {
            var fspec = this.ScheduledThrottles.AsFieldSpec(conf.Child("scheduledThrottles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scheduledThrottles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = new NetworkThrottleResourceId();

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        if (ec.Includes("archivalThrottlePort",true))
        {
            if(this.ArchivalThrottlePort == null) {

                this.ArchivalThrottlePort = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchivalThrottlePort != null && ec.Excludes("archivalThrottlePort",true))
        {
            this.ArchivalThrottlePort = null;
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        if (ec.Includes("defaultThrottleLimit",true))
        {
            if(this.DefaultThrottleLimit == null) {

                this.DefaultThrottleLimit = new System.Single();

            } else {


            }
        }
        else if (this.DefaultThrottleLimit != null && ec.Excludes("defaultThrottleLimit",true))
        {
            this.DefaultThrottleLimit = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        if (ec.Includes("networkInterface",true))
        {
            if(this.NetworkInterface == null) {

                this.NetworkInterface = "FETCH";

            } else {


            }
        }
        else if (this.NetworkInterface != null && ec.Excludes("networkInterface",true))
        {
            this.NetworkInterface = null;
        }
        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        if (ec.Includes("scheduledThrottles",false))
        {
            if(this.ScheduledThrottles == null) {

                this.ScheduledThrottles = new List<NetworkThrottleScheduleSummary>();
                this.ScheduledThrottles.ApplyExploratoryFieldSpec(ec.NewChild("scheduledThrottles"));

            } else {

                this.ScheduledThrottles.ApplyExploratoryFieldSpec(ec.NewChild("scheduledThrottles"));

            }
        }
        else if (this.ScheduledThrottles != null && ec.Excludes("scheduledThrottles",false))
        {
            this.ScheduledThrottles = null;
        }
    }


    #endregion

    } // class UpdateNetworkThrottleReply
    
    #endregion

    public static class ListUpdateNetworkThrottleReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UpdateNetworkThrottleReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateNetworkThrottleReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNetworkThrottleReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNetworkThrottleReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateNetworkThrottleReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types