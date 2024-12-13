// AwsEbsMetadata.cs
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
    #region AwsEbsMetadata
 
    public class AwsEbsMetadata: BaseType, ApplicationSpecificMetadata
    {
        #region members

        //      C# -> System.String? AttachedEc2Id
        // GraphQL -> attachedEc2Id: String! (scalar)
        [JsonProperty("attachedEc2Id")]
        public System.String? AttachedEc2Id { get; set; }

        //      C# -> System.String? AttachedEc2Name
        // GraphQL -> attachedEc2Name: String! (scalar)
        [JsonProperty("attachedEc2Name")]
        public System.String? AttachedEc2Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsEbsMetadata";
    }

    public AwsEbsMetadata Set(
        System.String? AttachedEc2Id = null,
        System.String? AttachedEc2Name = null
    ) 
    {
        if ( AttachedEc2Id != null ) {
            this.AttachedEc2Id = AttachedEc2Id;
        }
        if ( AttachedEc2Name != null ) {
            this.AttachedEc2Name = AttachedEc2Name;
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
        //      C# -> System.String? AttachedEc2Id
        // GraphQL -> attachedEc2Id: String! (scalar)
        if (this.AttachedEc2Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedEc2Id\n" ;
            } else {
                s += ind + "attachedEc2Id\n" ;
            }
        }
        //      C# -> System.String? AttachedEc2Name
        // GraphQL -> attachedEc2Name: String! (scalar)
        if (this.AttachedEc2Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedEc2Name\n" ;
            } else {
                s += ind + "attachedEc2Name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AttachedEc2Id
        // GraphQL -> attachedEc2Id: String! (scalar)
        if (ec.Includes("attachedEc2Id",true))
        {
            if(this.AttachedEc2Id == null) {

                this.AttachedEc2Id = "FETCH";

            } else {


            }
        }
        else if (this.AttachedEc2Id != null && ec.Excludes("attachedEc2Id",true))
        {
            this.AttachedEc2Id = null;
        }
        //      C# -> System.String? AttachedEc2Name
        // GraphQL -> attachedEc2Name: String! (scalar)
        if (ec.Includes("attachedEc2Name",true))
        {
            if(this.AttachedEc2Name == null) {

                this.AttachedEc2Name = "FETCH";

            } else {


            }
        }
        else if (this.AttachedEc2Name != null && ec.Excludes("attachedEc2Name",true))
        {
            this.AttachedEc2Name = null;
        }
    }


    #endregion

    } // class AwsEbsMetadata
    
    #endregion

    public static class ListAwsEbsMetadataExtensions
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
            this List<AwsEbsMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsEbsMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsEbsMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsEbsMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsEbsMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types