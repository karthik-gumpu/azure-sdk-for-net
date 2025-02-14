// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class Import : IJsonModel<Import>
    {
        void IJsonModel<Import>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Import IJsonModel<Import>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Import JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Import>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Import IPersistableModel<Import>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Import PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Import>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="import"> The <see cref="Import"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Import import) => throw null;

        public static explicit operator Import(Response result) => throw null;
    }
}
