﻿// Copyright (C) 2018 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace com.clover.remotepay.data
{
    public enum Methods
    {
        AAA_NULL,
        ACK,
        CLOSEOUT_RESPONSE,
        CLOSEOUT_REQUEST,
        CAPTURE_PREAUTH_RESPONSE,
        CAPTURE_PREAUTH,
        LAST_MSG_REQUEST,
        LAST_MSG_RESPONSE,
        TIP_ADJUST,
        TIP_ADJUST_RESPONSE,
        OPEN_CASH_DRAWER,
        SHOW_PAYMENT_RECEIPT_OPTIONS,
        SHOW_REFUND_RECEIPT_OPTIONS,
        SHOW_CREDIT_RECEIPT_OPTIONS,
        REFUND_RESPONSE,
        REFUND_REQUEST,
        TX_START,
        TX_START_RESPONSE,
        KEY_PRESS,
        UI_STATE,
        TX_STATE,
        FINISH_OK,
        FINISH_CANCEL,
        DISCOVERY_REQUEST,
        DISCOVERY_RESPONSE,
        TIP_ADDED,
        VERIFY_SIGNATURE,
        SIGNATURE_VERIFIED,
        PAYMENT_VOIDED,
        PRINT_PAYMENT,
        REFUND_PRINT_PAYMENT,
        PRINT_PAYMENT_MERCHANT_COPY,
        PRINT_CREDIT,
        PRINT_PAYMENT_DECLINE,
        PRINT_CREDIT_DECLINE,
        PRINT_TEXT,
        PRINT_IMAGE,
        TERMINAL_MESSAGE,
        SHOW_WELCOME_SCREEN,
        SHOW_THANK_YOU_SCREEN,
        SHOW_ORDER_SCREEN,
        BREAK,
        CASHBACK_SELECTED,
        PARTIAL_AUTH,
        VOID_PAYMENT,
        VOID_PAYMENT_RESPONSE,
        ORDER_ACTION_ADD_DISCOUNT,
        ORDER_ACTION_REMOVE_DISCOUNT,
        ORDER_ACTION_ADD_LINE_ITEM,
        ORDER_ACTION_REMOVE_LINE_ITEM,
        ORDER_ACTION_RESPONSE,
        VAULT_CARD,
        VAULT_CARD_RESPONSE,
        CARD_DATA,
        CARD_DATA_RESPONSE,
        LOG_MESSAGE,
        CONFIRM_PAYMENT_MESSAGE,
        PAYMENT_CONFIRMED,
        PAYMENT_REJECTED,
        RETRIEVE_PENDING_PAYMENTS,
        RETRIEVE_PENDING_PAYMENTS_RESPONSE,
        ACTIVITY_REQUEST,
        ACTIVITY_RESPONSE,
        REMOTE_ERROR,
        RETRIEVE_DEVICE_STATUS_REQUEST,
        RETRIEVE_DEVICE_STATUS_RESPONSE,
        CONFIGURATION_CHANGE,
        RESET_DEVICE_RESPONSE,
        ACTIVITY_MESSAGE_TO_ACTIVITY,
        ACTIVITY_MESSAGE_FROM_ACTIVITY,
        RETRIEVE_PAYMENT_REQUEST,
        RETRIEVE_PAYMENT_RESPONSE,
        PRINT_JOB_STATUS_REQUEST,
        PRINT_JOB_STATUS_RESPONSE,
        GET_PRINTERS_REQUEST,
        GET_PRINTERS_RESPONSE,
        CLOVER_DEVICE_LOG_REQUEST,
        SHOW_RECEIPT_OPTIONS,
        SHOW_RECEIPT_OPTIONS_RESPONSE,
        VOID_PAYMENT_REFUND,
        VOID_PAYMENT_REFUND_RESPONSE,
        REGISTER_FOR_CUST_DATA,
        CUSTOMER_INFO_MESSAGE,
        CUSTOMER_PROVIDED_DATA_MESSAGE,
        INVALID_STATE_TRANSITION
    }

    public enum MessageTypes
    {
        COMMAND,
        QUERY,
        EVENT,
        PING,
        PONG
    }
}
