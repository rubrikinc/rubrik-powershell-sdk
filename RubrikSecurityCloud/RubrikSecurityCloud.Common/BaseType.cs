using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public abstract class BaseType : IFieldSpec
    {
        // pointer to next object in chain.
        // Used for building up a chain of objects
        // to represent a "composite field spec".
        internal BaseType? _next = null;

        // IFieldSpec interface:
        public abstract string AsFieldSpec(FieldSpecConfig? conf=null);
        public abstract void ApplyExploratoryFieldSpec(ExplorationContext ec);
        public void SelectForRetrieval()
        {
            this.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
        // Returns the name of the type as it would appear in a GraphQL schema.
        // Should be overridden if the GraphQL type name is different from 
        // the C# class name.
        public virtual string GetGqlTypeName()
        {
            return this.GetType().Name;
        }
    }

    public static class ListBaseTypeExtensions
    {
        public static string AsFieldSpec(this List<BaseType> list,
                                         FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            string ind = conf.IndentStr();
            StringBuilder sb = new StringBuilder();
            foreach (BaseType item in list)
            {
                if(conf.Flat) {
                    sb.Append(item.AsFieldSpec(conf.Child()));
                } else {
                    sb.Append(ind + " ... on " + item.GetType().Name + " {\n" + item.AsFieldSpec(conf.Child()) + ind + "}\n");
                }
            }
            return sb.ToString();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BaseType> list,
            ExplorationContext ec)
        {
            foreach (BaseType item in list)
            {
                item.ApplyExploratoryFieldSpec(ec);
            }
        }

        public static void SelectForRetrieval(this List<BaseType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }
}
