﻿/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

using System;
using System.Collections.Generic;

namespace com.clover.sdk.v3.payments
{
    public class TransactionSettings
    {

        /**
        * Initialize the values for this.
        * @private
        */
        public TransactionSettings()
        {
        }
        public int? cardEntryMethods { get; set; }
        public bool? disableCashBack { get; set; }
        public bool? cloverShouldHandleReceipts { get; set; }
        public bool? forcePinEntryOnSwipe { get; set; }
        public bool? disableRestartTransactionOnFailure { get; set; }
        public bool? allowOfflinePayment { get; set; }
        public bool? approveOfflinePaymentWithoutPrompt { get; set; }
        public long? signatureThreshold { get; set; }
        public com.clover.sdk.v3.payments.DataEntryLocation? signatureEntryLocation { get; set; }
        public com.clover.sdk.v3.payments.TipMode? tipMode { get; set; }
        public long? tippableAmount { get; set; }
        public bool? disableReceiptSelection { get; set; }
        public bool? disableDuplicateCheck { get; set; }
        public bool? autoAcceptPaymentConfirmations { get; set; }
        public bool? autoAcceptSignature { get; set; }
        public bool? forceOfflinePayment { get; set; }
    }
}
