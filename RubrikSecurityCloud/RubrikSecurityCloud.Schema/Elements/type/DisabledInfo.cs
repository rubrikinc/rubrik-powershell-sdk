// DisabledInfo.cs
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
    #region DisabledInfo
    public class DisabledInfo: BaseType
    {
        #region members

        //      C# -> System.String? DisabledBy
        // GraphQL -> disabledBy: String! (scalar)
        [JsonProperty("disabledBy")]
        public System.String? DisabledBy { get; set; }

        //      C# -> DateTime? DisabledTime
        // GraphQL -> disabledTime: DateTime (scalar)
        [JsonProperty("disabledTime")]
        public DateTime? DisabledTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DisabledInfo";
    }

    public DisabledInfo Set(
        System.String? DisabledBy = null,
        DateTime? DisabledTime = null
    ) 
    {
        if ( DisabledBy != null ) {
            this.DisabledBy = DisabledBy;
        }
        if ( DisabledTime != null ) {
            this.DisabledTime = DisabledTime;
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
        //      C# -> System.String? DisabledBy
        // GraphQL -> disabledBy: String! (scalar)
        if (this.DisabledBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disabledBy\n" ;
            } else {
                s += ind + "disabledBy\n" ;
            }
        }
        //      C# -> DateTime? DisabledTime
        // GraphQL -> disabledTime: DateTime (scalar)
        if (this.DisabledTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disabledTime\n" ;
            } else {
                s += ind + "disabledTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DisabledBy
        // GraphQL -> disabledBy: String! (scalar)
        if (ec.Includes("disabledBy",true))
        {
            if(this.DisabledBy == null) {

                this.DisabledBy = "FETCH";

            } else {


            }
        }
        else if (this.DisabledBy != null && ec.Excludes("disabledBy",true))
        {
            this.DisabledBy = null;
        }
        //      C# -> DateTime? DisabledTime
        // GraphQL -> disabledTime: DateTime (scalar)
        if (ec.Includes("disabledTime",true))
        {
            if(this.DisabledTime == null) {

                this.DisabledTime = new DateTime();

            } else {


            }
        }
        else if (this.DisabledTime != null && ec.Excludes("disabledTime",true))
        {
            this.DisabledTime = null;
        }
    }


    #endregion

    } // class DisabledInfo
    
    #endregion

    public static class ListDisabledInfoExtensions
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
            this List<DisabledInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DisabledInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DisabledInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DisabledInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DisabledInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types