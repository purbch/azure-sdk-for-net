// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Barcode kind. </summary>
    public readonly partial struct DocumentBarcodeKind : IEquatable<DocumentBarcodeKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentBarcodeKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentBarcodeKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QRCodeValue = "QRCode";
        private const string PDF417Value = "PDF417";
        private const string UpcaValue = "UPCA";
        private const string UpceValue = "UPCE";
        private const string Code39Value = "Code39";
        private const string Code128Value = "Code128";
        private const string EAN8Value = "EAN8";
        private const string EAN13Value = "EAN13";
        private const string DataBarValue = "DataBar";
        private const string Code93Value = "Code93";
        private const string CodabarValue = "Codabar";
        private const string DataBarExpandedValue = "DataBarExpanded";
        private const string ITFValue = "ITF";
        private const string MicroQRCodeValue = "MicroQRCode";
        private const string AztecValue = "Aztec";
        private const string DataMatrixValue = "DataMatrix";
        private const string MaxiCodeValue = "MaxiCode";

        /// <summary> QR code, as defined in ISO/IEC 18004:2015. </summary>
        public static DocumentBarcodeKind QRCode { get; } = new DocumentBarcodeKind(QRCodeValue);
        /// <summary> PDF417, as defined in ISO 15438. </summary>
        public static DocumentBarcodeKind PDF417 { get; } = new DocumentBarcodeKind(PDF417Value);
        /// <summary> GS1 12-digit Universal Product Code. </summary>
        public static DocumentBarcodeKind Upca { get; } = new DocumentBarcodeKind(UpcaValue);
        /// <summary> GS1 6-digit Universal Product Code. </summary>
        public static DocumentBarcodeKind Upce { get; } = new DocumentBarcodeKind(UpceValue);
        /// <summary> Code 39 barcode, as defined in ISO/IEC 16388:2007. </summary>
        public static DocumentBarcodeKind Code39 { get; } = new DocumentBarcodeKind(Code39Value);
        /// <summary> Code 128 barcode, as defined in ISO/IEC 15417:2007. </summary>
        public static DocumentBarcodeKind Code128 { get; } = new DocumentBarcodeKind(Code128Value);
        /// <summary> GS1 8-digit International Article Number (European Article Number). </summary>
        public static DocumentBarcodeKind EAN8 { get; } = new DocumentBarcodeKind(EAN8Value);
        /// <summary> GS1 13-digit International Article Number (European Article Number). </summary>
        public static DocumentBarcodeKind EAN13 { get; } = new DocumentBarcodeKind(EAN13Value);
        /// <summary> GS1 DataBar barcode. </summary>
        public static DocumentBarcodeKind DataBar { get; } = new DocumentBarcodeKind(DataBarValue);
        /// <summary> Code 93 barcode, as defined in ANSI/AIM BC5-1995. </summary>
        public static DocumentBarcodeKind Code93 { get; } = new DocumentBarcodeKind(Code93Value);
        /// <summary> Codabar barcode, as defined in ANSI/AIM BC3-1995. </summary>
        public static DocumentBarcodeKind Codabar { get; } = new DocumentBarcodeKind(CodabarValue);
        /// <summary> GS1 DataBar Expanded barcode. </summary>
        public static DocumentBarcodeKind DataBarExpanded { get; } = new DocumentBarcodeKind(DataBarExpandedValue);
        /// <summary> Interleaved 2 of 5 barcode, as defined in ANSI/AIM BC2-1995. </summary>
        public static DocumentBarcodeKind ITF { get; } = new DocumentBarcodeKind(ITFValue);
        /// <summary> Micro QR code, as defined in ISO/IEC 23941:2022. </summary>
        public static DocumentBarcodeKind MicroQRCode { get; } = new DocumentBarcodeKind(MicroQRCodeValue);
        /// <summary> Aztec code, as defined in ISO/IEC 24778:2008. </summary>
        public static DocumentBarcodeKind Aztec { get; } = new DocumentBarcodeKind(AztecValue);
        /// <summary> Data matrix code, as defined in ISO/IEC 16022:2006. </summary>
        public static DocumentBarcodeKind DataMatrix { get; } = new DocumentBarcodeKind(DataMatrixValue);
        /// <summary> MaxiCode, as defined in ISO/IEC 16023:2000. </summary>
        public static DocumentBarcodeKind MaxiCode { get; } = new DocumentBarcodeKind(MaxiCodeValue);
        /// <summary> Determines if two <see cref="DocumentBarcodeKind"/> values are the same. </summary>
        public static bool operator ==(DocumentBarcodeKind left, DocumentBarcodeKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentBarcodeKind"/> values are not the same. </summary>
        public static bool operator !=(DocumentBarcodeKind left, DocumentBarcodeKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentBarcodeKind"/>. </summary>
        public static implicit operator DocumentBarcodeKind(string value) => new DocumentBarcodeKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentBarcodeKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentBarcodeKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
