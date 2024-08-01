using Newtonsoft.Json;
using RubrikSecurityCloud.Client.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Client
{
    public class EnumJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            Type type = Nullable.GetUnderlyingType(objectType) ?? objectType;
            if (type.IsEnum)
            {
                return true;
            }

            if (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type itemType = objectType.GetGenericArguments()[0];
                Type actualItemType = Nullable.GetUnderlyingType(itemType) ?? itemType;
                return actualItemType.IsEnum;
            }

            return false;
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        ) {
            Type enumType = Nullable.GetUnderlyingType(objectType) ?? objectType;

            if (reader.TokenType == JsonToken.Null)
            {
                return null; // Allow null values
            }

            if (reader.TokenType == JsonToken.StartArray)
            {
                // Handle list of enum values
                Type listElementType = GetListElementType(objectType);
                IList list = CreateListInstance(objectType);

                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    if (reader.TokenType == JsonToken.Null)
                    {
                        list.Add(null);
                    }
                    else
                    {
                        var item = ReadSingleEnumValue(reader, listElementType);
                        list.Add(item);
                    }
                }
                return list;
            }

            // Handle single enum value
            return ReadSingleEnumValue(reader, enumType);
        }

        private Type GetListElementType(Type listType)
        {
            // Get the generic argument type (T) for List<T>, considering nullable types
            Type itemType = listType.GetGenericArguments()[0];
            return Nullable.GetUnderlyingType(itemType) ?? itemType;
        }

        private IList CreateListInstance(Type listTypeIn)
        {
            Type itemType = listTypeIn.GetGenericArguments()[0];
            Type listTypeOut = typeof(List<>).MakeGenericType(itemType);
            return (IList)Activator.CreateInstance(listTypeOut);
        }

        private object ReadSingleEnumValue(JsonReader reader, Type enumType)
        {
            try
            {
                if (reader.TokenType == JsonToken.Null)
                {
                    return null; // Handle null values
                }

                if (reader.TokenType == JsonToken.String)
                {
                    string enumText = reader.Value.ToString();
                    foreach (var field in enumType.GetFields())
                    {
                        var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
                        if (attribute != null && attribute.Value == enumText)
                        {
                            return field.GetValue(null);
                        }
                        if (field.Name.Equals(enumText, StringComparison.OrdinalIgnoreCase))
                        {
                            return field.GetValue(null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting value {reader.Value} to type '{enumType}'.", ex);
            }

            if (RubrikSecurityCloud.Config.SchemaStrict)
            {
                throw new RscServerSchemaMismatchException(
                    $"SDK is using an outdated API schema. Could not convert value {reader.Value} to type '{enumType}'."
                );
            }
            // If no match is found, return the default UNKNOWN value
            return GetDefaultUnknownValue(enumType);
        }

        private object GetDefaultUnknownValue(Type enumType)
        {
            FieldInfo unknownField = enumType.GetField("UNKNOWN");
            if (unknownField != null)
            {
                return unknownField.GetValue(null);
            }

            throw new JsonSerializationException($"Enum type '{enumType.FullName}' does not have an 'UNKNOWN' value.");
        }

        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        ) {
            throw new NotImplementedException("The WriteJson method is not implemented.");
        }
    }
}
