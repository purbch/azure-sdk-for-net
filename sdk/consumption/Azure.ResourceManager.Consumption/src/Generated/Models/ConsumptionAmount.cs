// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// The amount plus currency .
    /// Serialized Name: Amount
    /// </summary>
    public partial class ConsumptionAmount
    {
        /// <summary> Initializes a new instance of ConsumptionAmount. </summary>
        internal ConsumptionAmount()
        {
        }

        /// <summary> Initializes a new instance of ConsumptionAmount. </summary>
        /// <param name="currency">
        /// Amount currency.
        /// Serialized Name: Amount.currency
        /// </param>
        /// <param name="value">
        /// Amount.
        /// Serialized Name: Amount.value
        /// </param>
        internal ConsumptionAmount(string currency, decimal? value)
        {
            Currency = currency;
            Value = value;
        }

        /// <summary>
        /// Amount currency.
        /// Serialized Name: Amount.currency
        /// </summary>
        public string Currency { get; }
        /// <summary>
        /// Amount.
        /// Serialized Name: Amount.value
        /// </summary>
        public decimal? Value { get; }
    }
}
