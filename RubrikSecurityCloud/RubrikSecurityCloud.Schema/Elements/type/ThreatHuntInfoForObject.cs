// ThreatHuntInfoForObject.cs
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
    #region ThreatHuntInfoForObject
    public class ThreatHuntInfoForObject: BaseType
    {
        #region members

        //      C# -> System.String? HuntFid
        // GraphQL -> huntFid: String! (scalar)
        [JsonProperty("huntFid")]
        public System.String? HuntFid { get; set; }

        //      C# -> DateTime? HuntStartTime
        // GraphQL -> huntStartTime: DateTime (scalar)
        [JsonProperty("huntStartTime")]
        public DateTime? HuntStartTime { get; set; }

        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        [JsonProperty("isObjectMalicious")]
        public System.Boolean? IsObjectMalicious { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntInfoForObject";
    }

    public ThreatHuntInfoForObject Set(
        System.String? HuntFid = null,
        DateTime? HuntStartTime = null,
        System.Boolean? IsObjectMalicious = null,
        System.String? ObjectFid = null
    ) 
    {
        if ( HuntFid != null ) {
            this.HuntFid = HuntFid;
        }
        if ( HuntStartTime != null ) {
            this.HuntStartTime = HuntStartTime;
        }
        if ( IsObjectMalicious != null ) {
            this.IsObjectMalicious = IsObjectMalicious;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
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
        //      C# -> System.String? HuntFid
        // GraphQL -> huntFid: String! (scalar)
        if (this.HuntFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntFid\n" ;
            } else {
                s += ind + "huntFid\n" ;
            }
        }
        //      C# -> DateTime? HuntStartTime
        // GraphQL -> huntStartTime: DateTime (scalar)
        if (this.HuntStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntStartTime\n" ;
            } else {
                s += ind + "huntStartTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        if (this.IsObjectMalicious != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isObjectMalicious\n" ;
            } else {
                s += ind + "isObjectMalicious\n" ;
            }
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HuntFid
        // GraphQL -> huntFid: String! (scalar)
        if (ec.Includes("huntFid",true))
        {
            if(this.HuntFid == null) {

                this.HuntFid = "FETCH";

            } else {


            }
        }
        else if (this.HuntFid != null && ec.Excludes("huntFid",true))
        {
            this.HuntFid = null;
        }
        //      C# -> DateTime? HuntStartTime
        // GraphQL -> huntStartTime: DateTime (scalar)
        if (ec.Includes("huntStartTime",true))
        {
            if(this.HuntStartTime == null) {

                this.HuntStartTime = new DateTime();

            } else {


            }
        }
        else if (this.HuntStartTime != null && ec.Excludes("huntStartTime",true))
        {
            this.HuntStartTime = null;
        }
        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        if (ec.Includes("isObjectMalicious",true))
        {
            if(this.IsObjectMalicious == null) {

                this.IsObjectMalicious = true;

            } else {


            }
        }
        else if (this.IsObjectMalicious != null && ec.Excludes("isObjectMalicious",true))
        {
            this.IsObjectMalicious = null;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
    }


    #endregion

    } // class ThreatHuntInfoForObject
    
    #endregion

    public static class ListThreatHuntInfoForObjectExtensions
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
            this List<ThreatHuntInfoForObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntInfoForObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntInfoForObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntInfoForObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntInfoForObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types