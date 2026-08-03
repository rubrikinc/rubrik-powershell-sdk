// TagPermission.cs
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
    #region TagPermission
    public class TagPermission: BaseType
    {
        #region members

        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        [JsonProperty("operation")]
        public Operation? Operation { get; set; }

        //      C# -> List<System.String>? TagIds
        // GraphQL -> tagIds: [UUID!]! (scalar)
        [JsonProperty("tagIds")]
        public List<System.String>? TagIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TagPermission";
    }

    public TagPermission Set(
        Operation? Operation = null,
        List<System.String>? TagIds = null
    ) 
    {
        if ( Operation != null ) {
            this.Operation = Operation;
        }
        if ( TagIds != null ) {
            this.TagIds = TagIds;
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
        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        if (this.Operation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operation\n" ;
            } else {
                s += ind + "operation\n" ;
            }
        }
        //      C# -> List<System.String>? TagIds
        // GraphQL -> tagIds: [UUID!]! (scalar)
        if (this.TagIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tagIds\n" ;
            } else {
                s += ind + "tagIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        if (ec.Includes("operation",true))
        {
            if(this.Operation == null) {

                this.Operation = new Operation();

            } else {


            }
        }
        else if (this.Operation != null && ec.Excludes("operation",true))
        {
            this.Operation = null;
        }
        //      C# -> List<System.String>? TagIds
        // GraphQL -> tagIds: [UUID!]! (scalar)
        if (ec.Includes("tagIds",true))
        {
            if(this.TagIds == null) {

                this.TagIds = new List<System.String>();

            } else {


            }
        }
        else if (this.TagIds != null && ec.Excludes("tagIds",true))
        {
            this.TagIds = null;
        }
    }


    #endregion

    } // class TagPermission
    
    #endregion

    public static class ListTagPermissionExtensions
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
            this List<TagPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TagPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TagPermission> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TagPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TagPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types