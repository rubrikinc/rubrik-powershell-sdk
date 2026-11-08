// ApplicationResourceTypeCount.cs
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
    #region ApplicationResourceTypeCount
    public class ApplicationResourceTypeCount: BaseType
    {
        #region members

        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        [JsonProperty("protectionStatus")]
        public CloudNativeProtectionStatus? ProtectionStatus { get; set; }

        //      C# -> List<ApplicationWarningFlag>? WarningFlags
        // GraphQL -> warningFlags: [ApplicationWarningFlag!]! (enum)
        [JsonProperty("warningFlags")]
        public List<ApplicationWarningFlag>? WarningFlags { get; set; }

        //      C# -> System.Int64? AutoDiscoveryCount
        // GraphQL -> autoDiscoveryCount: Long! (scalar)
        [JsonProperty("autoDiscoveryCount")]
        public System.Int64? AutoDiscoveryCount { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.Int64? ManuallySelectedCount
        // GraphQL -> manuallySelectedCount: Long! (scalar)
        [JsonProperty("manuallySelectedCount")]
        public System.Int64? ManuallySelectedCount { get; set; }

        //      C# -> System.Int64? TagBasedCount
        // GraphQL -> tagBasedCount: Long! (scalar)
        [JsonProperty("tagBasedCount")]
        public System.Int64? TagBasedCount { get; set; }

        //      C# -> ApplicationResourceTypeFilter? ResourceType
        // GraphQL -> resourceType: ApplicationResourceTypeFilter! (type)
        [JsonProperty("resourceType")]
        public ApplicationResourceTypeFilter? ResourceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationResourceTypeCount";
    }

    public ApplicationResourceTypeCount Set(
        CloudNativeProtectionStatus? ProtectionStatus = null,
        List<ApplicationWarningFlag>? WarningFlags = null,
        System.Int64? AutoDiscoveryCount = null,
        System.Int64? Count = null,
        System.Int64? ManuallySelectedCount = null,
        System.Int64? TagBasedCount = null,
        ApplicationResourceTypeFilter? ResourceType = null
    ) 
    {
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( WarningFlags != null ) {
            this.WarningFlags = WarningFlags;
        }
        if ( AutoDiscoveryCount != null ) {
            this.AutoDiscoveryCount = AutoDiscoveryCount;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( ManuallySelectedCount != null ) {
            this.ManuallySelectedCount = ManuallySelectedCount;
        }
        if ( TagBasedCount != null ) {
            this.TagBasedCount = TagBasedCount;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
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
        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> List<ApplicationWarningFlag>? WarningFlags
        // GraphQL -> warningFlags: [ApplicationWarningFlag!]! (enum)
        if (this.WarningFlags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warningFlags\n" ;
            } else {
                s += ind + "warningFlags\n" ;
            }
        }
        //      C# -> System.Int64? AutoDiscoveryCount
        // GraphQL -> autoDiscoveryCount: Long! (scalar)
        if (this.AutoDiscoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoDiscoveryCount\n" ;
            } else {
                s += ind + "autoDiscoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.Int64? ManuallySelectedCount
        // GraphQL -> manuallySelectedCount: Long! (scalar)
        if (this.ManuallySelectedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "manuallySelectedCount\n" ;
            } else {
                s += ind + "manuallySelectedCount\n" ;
            }
        }
        //      C# -> System.Int64? TagBasedCount
        // GraphQL -> tagBasedCount: Long! (scalar)
        if (this.TagBasedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tagBasedCount\n" ;
            } else {
                s += ind + "tagBasedCount\n" ;
            }
        }
        //      C# -> ApplicationResourceTypeFilter? ResourceType
        // GraphQL -> resourceType: ApplicationResourceTypeFilter! (type)
        if (this.ResourceType != null) {
            var fspec = this.ResourceType.AsFieldSpec(conf.Child("resourceType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new CloudNativeProtectionStatus();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> List<ApplicationWarningFlag>? WarningFlags
        // GraphQL -> warningFlags: [ApplicationWarningFlag!]! (enum)
        if (ec.Includes("warningFlags",true))
        {
            if(this.WarningFlags == null) {

                this.WarningFlags = new List<ApplicationWarningFlag>();

            } else {


            }
        }
        else if (this.WarningFlags != null && ec.Excludes("warningFlags",true))
        {
            this.WarningFlags = null;
        }
        //      C# -> System.Int64? AutoDiscoveryCount
        // GraphQL -> autoDiscoveryCount: Long! (scalar)
        if (ec.Includes("autoDiscoveryCount",true))
        {
            if(this.AutoDiscoveryCount == null) {

                this.AutoDiscoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.AutoDiscoveryCount != null && ec.Excludes("autoDiscoveryCount",true))
        {
            this.AutoDiscoveryCount = null;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = new System.Int64();

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.Int64? ManuallySelectedCount
        // GraphQL -> manuallySelectedCount: Long! (scalar)
        if (ec.Includes("manuallySelectedCount",true))
        {
            if(this.ManuallySelectedCount == null) {

                this.ManuallySelectedCount = new System.Int64();

            } else {


            }
        }
        else if (this.ManuallySelectedCount != null && ec.Excludes("manuallySelectedCount",true))
        {
            this.ManuallySelectedCount = null;
        }
        //      C# -> System.Int64? TagBasedCount
        // GraphQL -> tagBasedCount: Long! (scalar)
        if (ec.Includes("tagBasedCount",true))
        {
            if(this.TagBasedCount == null) {

                this.TagBasedCount = new System.Int64();

            } else {


            }
        }
        else if (this.TagBasedCount != null && ec.Excludes("tagBasedCount",true))
        {
            this.TagBasedCount = null;
        }
        //      C# -> ApplicationResourceTypeFilter? ResourceType
        // GraphQL -> resourceType: ApplicationResourceTypeFilter! (type)
        if (ec.Includes("resourceType",false))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new ApplicationResourceTypeFilter();
                this.ResourceType.ApplyExploratoryFieldSpec(ec.NewChild("resourceType"));

            } else {

                this.ResourceType.ApplyExploratoryFieldSpec(ec.NewChild("resourceType"));

            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",false))
        {
            this.ResourceType = null;
        }
    }


    #endregion

    } // class ApplicationResourceTypeCount
    
    #endregion

    public static class ListApplicationResourceTypeCountExtensions
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
            this List<ApplicationResourceTypeCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationResourceTypeCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationResourceTypeCount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationResourceTypeCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationResourceTypeCount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types