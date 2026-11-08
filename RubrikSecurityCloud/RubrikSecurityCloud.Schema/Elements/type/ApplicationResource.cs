// ApplicationResource.cs
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
    #region ApplicationResource
    public class ApplicationResource: BaseType
    {
        #region members

        //      C# -> DiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: DiscoveryMethod! (enum)
        [JsonProperty("discoveryMethod")]
        public DiscoveryMethod? DiscoveryMethod { get; set; }

        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        [JsonProperty("protectionStatus")]
        public CloudNativeProtectionStatus? ProtectionStatus { get; set; }

        //      C# -> List<ApplicationWarningFlag>? WarningFlags
        // GraphQL -> warningFlags: [ApplicationWarningFlag!]! (enum)
        [JsonProperty("warningFlags")]
        public List<ApplicationWarningFlag>? WarningFlags { get; set; }

        //      C# -> System.String? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: String! (scalar)
        [JsonProperty("effectiveSlaDomain")]
        public System.String? EffectiveSlaDomain { get; set; }

        //      C# -> Resource? Resource
        // GraphQL -> resource: Resource (type)
        [JsonProperty("resource")]
        public Resource? Resource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationResource";
    }

    public ApplicationResource Set(
        DiscoveryMethod? DiscoveryMethod = null,
        CloudNativeProtectionStatus? ProtectionStatus = null,
        List<ApplicationWarningFlag>? WarningFlags = null,
        System.String? EffectiveSlaDomain = null,
        Resource? Resource = null
    ) 
    {
        if ( DiscoveryMethod != null ) {
            this.DiscoveryMethod = DiscoveryMethod;
        }
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( WarningFlags != null ) {
            this.WarningFlags = WarningFlags;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( Resource != null ) {
            this.Resource = Resource;
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
        //      C# -> DiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: DiscoveryMethod! (enum)
        if (this.DiscoveryMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "discoveryMethod\n" ;
            } else {
                s += ind + "discoveryMethod\n" ;
            }
        }
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
        //      C# -> System.String? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: String! (scalar)
        if (this.EffectiveSlaDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomain\n" ;
            } else {
                s += ind + "effectiveSlaDomain\n" ;
            }
        }
        //      C# -> Resource? Resource
        // GraphQL -> resource: Resource (type)
        if (this.Resource != null) {
            var fspec = this.Resource.AsFieldSpec(conf.Child("resource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: DiscoveryMethod! (enum)
        if (ec.Includes("discoveryMethod",true))
        {
            if(this.DiscoveryMethod == null) {

                this.DiscoveryMethod = new DiscoveryMethod();

            } else {


            }
        }
        else if (this.DiscoveryMethod != null && ec.Excludes("discoveryMethod",true))
        {
            this.DiscoveryMethod = null;
        }
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
        //      C# -> System.String? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: String! (scalar)
        if (ec.Includes("effectiveSlaDomain",true))
        {
            if(this.EffectiveSlaDomain == null) {

                this.EffectiveSlaDomain = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",true))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> Resource? Resource
        // GraphQL -> resource: Resource (type)
        if (ec.Includes("resource",false))
        {
            if(this.Resource == null) {

                this.Resource = new Resource();
                this.Resource.ApplyExploratoryFieldSpec(ec.NewChild("resource"));

            } else {

                this.Resource.ApplyExploratoryFieldSpec(ec.NewChild("resource"));

            }
        }
        else if (this.Resource != null && ec.Excludes("resource",false))
        {
            this.Resource = null;
        }
    }


    #endregion

    } // class ApplicationResource
    
    #endregion

    public static class ListApplicationResourceExtensions
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
            this List<ApplicationResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types