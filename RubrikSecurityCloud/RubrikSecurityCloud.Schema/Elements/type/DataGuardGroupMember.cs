// DataGuardGroupMember.cs
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
    #region DataGuardGroupMember
    public class DataGuardGroupMember: BaseType
    {
        #region members

        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        [JsonProperty("racId")]
        public System.String? RacId { get; set; }

        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        [JsonProperty("racName")]
        public System.String? RacName { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        [JsonProperty("standaloneHostId")]
        public System.String? StandaloneHostId { get; set; }

        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        [JsonProperty("standaloneHostName")]
        public System.String? StandaloneHostName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataGuardGroupMember";
    }

    public DataGuardGroupMember Set(
        System.String? DbUniqueName = null,
        System.String? RacId = null,
        System.String? RacName = null,
        System.String? Role = null,
        System.String? StandaloneHostId = null,
        System.String? StandaloneHostName = null
    ) 
    {
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( RacId != null ) {
            this.RacId = RacId;
        }
        if ( RacName != null ) {
            this.RacName = RacName;
        }
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( StandaloneHostId != null ) {
            this.StandaloneHostId = StandaloneHostId;
        }
        if ( StandaloneHostName != null ) {
            this.StandaloneHostName = StandaloneHostName;
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
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (this.DbUniqueName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbUniqueName\n" ;
            } else {
                s += ind + "dbUniqueName\n" ;
            }
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "racId\n" ;
            } else {
                s += ind + "racId\n" ;
            }
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "racName\n" ;
            } else {
                s += ind + "racName\n" ;
            }
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "standaloneHostId\n" ;
            } else {
                s += ind + "standaloneHostId\n" ;
            }
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "standaloneHostName\n" ;
            } else {
                s += ind + "standaloneHostName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (ec.Includes("dbUniqueName",true))
        {
            if(this.DbUniqueName == null) {

                this.DbUniqueName = "FETCH";

            } else {


            }
        }
        else if (this.DbUniqueName != null && ec.Excludes("dbUniqueName",true))
        {
            this.DbUniqueName = null;
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (ec.Includes("racId",true))
        {
            if(this.RacId == null) {

                this.RacId = "FETCH";

            } else {


            }
        }
        else if (this.RacId != null && ec.Excludes("racId",true))
        {
            this.RacId = null;
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (ec.Includes("racName",true))
        {
            if(this.RacName == null) {

                this.RacName = "FETCH";

            } else {


            }
        }
        else if (this.RacName != null && ec.Excludes("racName",true))
        {
            this.RacName = null;
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = "FETCH";

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (ec.Includes("standaloneHostId",true))
        {
            if(this.StandaloneHostId == null) {

                this.StandaloneHostId = "FETCH";

            } else {


            }
        }
        else if (this.StandaloneHostId != null && ec.Excludes("standaloneHostId",true))
        {
            this.StandaloneHostId = null;
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (ec.Includes("standaloneHostName",true))
        {
            if(this.StandaloneHostName == null) {

                this.StandaloneHostName = "FETCH";

            } else {


            }
        }
        else if (this.StandaloneHostName != null && ec.Excludes("standaloneHostName",true))
        {
            this.StandaloneHostName = null;
        }
    }


    #endregion

    } // class DataGuardGroupMember
    
    #endregion

    public static class ListDataGuardGroupMemberExtensions
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
            this List<DataGuardGroupMember> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataGuardGroupMember> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataGuardGroupMember> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataGuardGroupMember());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataGuardGroupMember> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types