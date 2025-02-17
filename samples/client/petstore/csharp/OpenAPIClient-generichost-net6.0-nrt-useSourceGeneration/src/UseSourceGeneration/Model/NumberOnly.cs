// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// NumberOnly
    /// </summary>
    public partial class NumberOnly : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOnly" /> class.
        /// </summary>
        /// <param name="justNumber">justNumber</param>
        [JsonConstructor]
        public NumberOnly(decimal justNumber)
        {
            JustNumber = justNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets JustNumber
        /// </summary>
        [JsonPropertyName("JustNumber")]
        public decimal JustNumber { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NumberOnly {\n");
            sb.Append("  JustNumber: ").Append(JustNumber).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NumberOnly" />
    /// </summary>
    public class NumberOnlyJsonConverter : JsonConverter<NumberOnly>
    {
        /// <summary>
        /// Deserializes json to <see cref="NumberOnly" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NumberOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            decimal? justNumber = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "JustNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                justNumber = utf8JsonReader.GetDecimal();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (justNumber == null)
                throw new ArgumentNullException(nameof(justNumber), "Property is required for class NumberOnly.");

            return new NumberOnly(justNumber.Value);
        }

        /// <summary>
        /// Serializes a <see cref="NumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="numberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NumberOnly numberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, numberOnly, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="numberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NumberOnly numberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("JustNumber", numberOnly.JustNumber);
        }
    }

    /// <summary>
    /// The NumberOnlySerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(NumberOnly))]
    public partial class NumberOnlySerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The NumberOnlySerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public NumberOnlySerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// NumberOnlyDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(NumberOnly))]
    public partial class NumberOnlyDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// NumberOnlyDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public NumberOnlyDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
