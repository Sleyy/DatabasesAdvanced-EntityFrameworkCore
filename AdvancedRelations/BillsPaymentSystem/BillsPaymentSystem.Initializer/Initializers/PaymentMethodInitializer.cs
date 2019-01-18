﻿using BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Initializer.Initializers
{
    internal class PaymentMethodInitializer
    {
        public static PaymentMethod[] GetPaymentMethods()
        {
            PaymentMethod[] paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod() {Type = PaymentType.BankAccount, UserId = 1, BankAccountId = 1},
                new PaymentMethod() {Type = PaymentType.CreditCard, UserId = 2, CreditCardId = 2},
                new PaymentMethod() {Type = PaymentType.CreditCard, UserId = 3, CreditCardId = 3}
            };

            return paymentMethods;
        }
    }
}
