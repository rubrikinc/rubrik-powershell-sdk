// CloudNativeGatewayKmsKeyMapEntry.cs
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
    #region CloudNativeGatewayKmsKeyMapEntry
    public class CloudNativeGatewayKmsKeyMapEntry: BaseType
    {
        #region members

        //      C# -> System.String? KmsKeyArn
        // GraphQL -> kmsKeyArn: String! (scalar)
        [JsonProperty("kmsKeyArn")]
        public System.String? KmsKeyArn { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeGatewayKmsKeyMapEntry";
    }

    public CloudNativeGatewayKmsKeyMapEntry Set(
        System.String? KmsKeyArn = null,
        System.String? Region = null
    ) 
    {
        if ( KmsKeyArn != null ) {
            this.KmsKeyArn = KmsKeyArn;
        }
        if ( Region != null ) {
            this.Region = Region;
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
        //      C# -> System.String? KmsKeyArn
        // GraphQL -> kmsKeyArn: String! (scalar)
        if (this.KmsKeyArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKeyArn\n" ;
            } else {
                s += ind + "kmsKeyArn\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? KmsKeyArn
        // GraphQL -> kmsKeyArn: String! (scalar)
        if (ec.Includes("kmsKeyArn",true))
        {
            if(this.KmsKeyArn == null) {

                this.KmsKeyArn = "FETCH";

            } else {


            }
        }
        else if (this.KmsKeyArn != null && ec.Excludes("kmsKeyArn",true))
        {
            this.KmsKeyArn = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
    }


    #endregion

    } // class CloudNativeGatewayKmsKeyMapEntry
    
    #endregion

    public static class ListCloudNativeGatewayKmsKeyMapEntryExtensions
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
            this List<CloudNativeGatewayKmsKeyMapEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeGatewayKmsKeyMapEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeGatewayKmsKeyMapEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeGatewayKmsKeyMapEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeGatewayKmsKeyMapEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types