// GranularResourceProtection.cs
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
    #region GranularResourceProtection
    public class GranularResourceProtection: BaseType
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

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        [JsonProperty("resourceName")]
        public System.String? ResourceName { get; set; }

        //      C# -> GranularApplicationResourceType? ResourceType
        // GraphQL -> resourceType: GranularApplicationResourceType (type)
        [JsonProperty("resourceType")]
        public GranularApplicationResourceType? ResourceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GranularResourceProtection";
    }

    public GranularResourceProtection Set(
        CloudNativeProtectionStatus? ProtectionStatus = null,
        List<ApplicationWarningFlag>? WarningFlags = null,
        System.String? ResourceId = null,
        System.String? ResourceName = null,
        GranularApplicationResourceType? ResourceType = null
    ) 
    {
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( WarningFlags != null ) {
            this.WarningFlags = WarningFlags;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceName != null ) {
            this.ResourceName = ResourceName;
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
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceName\n" ;
            } else {
                s += ind + "resourceName\n" ;
            }
        }
        //      C# -> GranularApplicationResourceType? ResourceType
        // GraphQL -> resourceType: GranularApplicationResourceType (type)
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
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (ec.Includes("resourceName",true))
        {
            if(this.ResourceName == null) {

                this.ResourceName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceName != null && ec.Excludes("resourceName",true))
        {
            this.ResourceName = null;
        }
        //      C# -> GranularApplicationResourceType? ResourceType
        // GraphQL -> resourceType: GranularApplicationResourceType (type)
        if (ec.Includes("resourceType",false))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new GranularApplicationResourceType();
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

    } // class GranularResourceProtection
    
    #endregion

    public static class ListGranularResourceProtectionExtensions
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
            this List<GranularResourceProtection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GranularResourceProtection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GranularResourceProtection> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GranularResourceProtection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GranularResourceProtection> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types