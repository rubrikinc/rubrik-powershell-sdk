// CloudNativeApplicationInfo.cs
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
    #region CloudNativeApplicationInfo
    public class CloudNativeApplicationInfo: BaseType
    {
        #region members

        //      C# -> CloudNativeAppDiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: CloudNativeAppDiscoveryMethod! (enum)
        [JsonProperty("discoveryMethod")]
        public CloudNativeAppDiscoveryMethod? DiscoveryMethod { get; set; }

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        [JsonProperty("applicationName")]
        public System.String? ApplicationName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeApplicationInfo";
    }

    public CloudNativeApplicationInfo Set(
        CloudNativeAppDiscoveryMethod? DiscoveryMethod = null,
        System.String? ApplicationId = null,
        System.String? ApplicationName = null
    ) 
    {
        if ( DiscoveryMethod != null ) {
            this.DiscoveryMethod = DiscoveryMethod;
        }
        if ( ApplicationId != null ) {
            this.ApplicationId = ApplicationId;
        }
        if ( ApplicationName != null ) {
            this.ApplicationName = ApplicationName;
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
        //      C# -> CloudNativeAppDiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: CloudNativeAppDiscoveryMethod! (enum)
        if (this.DiscoveryMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "discoveryMethod\n" ;
            } else {
                s += ind + "discoveryMethod\n" ;
            }
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        if (this.ApplicationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationId\n" ;
            } else {
                s += ind + "applicationId\n" ;
            }
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (this.ApplicationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationName\n" ;
            } else {
                s += ind + "applicationName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeAppDiscoveryMethod? DiscoveryMethod
        // GraphQL -> discoveryMethod: CloudNativeAppDiscoveryMethod! (enum)
        if (ec.Includes("discoveryMethod",true))
        {
            if(this.DiscoveryMethod == null) {

                this.DiscoveryMethod = new CloudNativeAppDiscoveryMethod();

            } else {


            }
        }
        else if (this.DiscoveryMethod != null && ec.Excludes("discoveryMethod",true))
        {
            this.DiscoveryMethod = null;
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        if (ec.Includes("applicationId",true))
        {
            if(this.ApplicationId == null) {

                this.ApplicationId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationId != null && ec.Excludes("applicationId",true))
        {
            this.ApplicationId = null;
        }
        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String! (scalar)
        if (ec.Includes("applicationName",true))
        {
            if(this.ApplicationName == null) {

                this.ApplicationName = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationName != null && ec.Excludes("applicationName",true))
        {
            this.ApplicationName = null;
        }
    }


    #endregion

    } // class CloudNativeApplicationInfo
    
    #endregion

    public static class ListCloudNativeApplicationInfoExtensions
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
            this List<CloudNativeApplicationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeApplicationInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeApplicationInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeApplicationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeApplicationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types