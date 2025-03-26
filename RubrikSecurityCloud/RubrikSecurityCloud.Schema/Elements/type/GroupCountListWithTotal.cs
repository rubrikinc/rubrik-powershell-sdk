// GroupCountListWithTotal.cs
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
    #region GroupCountListWithTotal
    public class GroupCountListWithTotal: BaseType
    {
        #region members

        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        [JsonProperty("totalCount")]
        public System.Int32? TotalCount { get; set; }

        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        [JsonProperty("groupList")]
        public List<GroupCount>? GroupList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GroupCountListWithTotal";
    }

    public GroupCountListWithTotal Set(
        System.Int32? TotalCount = null,
        List<GroupCount>? GroupList = null
    ) 
    {
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( GroupList != null ) {
            this.GroupList = GroupList;
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
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        if (this.GroupList != null) {
            var fspec = this.GroupList.AsFieldSpec(conf.Child("groupList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        if (ec.Includes("groupList",false))
        {
            if(this.GroupList == null) {

                this.GroupList = new List<GroupCount>();
                this.GroupList.ApplyExploratoryFieldSpec(ec.NewChild("groupList"));

            } else {

                this.GroupList.ApplyExploratoryFieldSpec(ec.NewChild("groupList"));

            }
        }
        else if (this.GroupList != null && ec.Excludes("groupList",false))
        {
            this.GroupList = null;
        }
    }


    #endregion

    } // class GroupCountListWithTotal
    
    #endregion

    public static class ListGroupCountListWithTotalExtensions
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
            this List<GroupCountListWithTotal> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GroupCountListWithTotal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GroupCountListWithTotal> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupCountListWithTotal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GroupCountListWithTotal> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types