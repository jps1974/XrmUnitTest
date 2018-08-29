﻿// -----------------------------------------------------------------------------------
// <copyright file="AmbientTransactionStore.cs" company="NMemory Team">
//     Copyright (C) 2012-2014 NMemory Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// -----------------------------------------------------------------------------------

namespace NMemory.Transactions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections.Concurrent;

    internal static class AmbientTransactionStore
    {
        private static ConcurrentDictionary<string, Transaction> transactions;

        static AmbientTransactionStore()
        {
            transactions = new ConcurrentDictionary<string, Transaction>();
        }

        public static Transaction GetAmbientEnlistedTransaction(System.Transactions.Transaction ambient)
        {
            return transactions.GetOrAdd(ambient.TransactionInformation.LocalIdentifier, x => CreateTransaction(ambient));
        }

        public static void RemoveTransaction(System.Transactions.Transaction ambient)
        {
            transactions.TryRemove(ambient.TransactionInformation.LocalIdentifier, out Transaction removedTransaction);
        }

        private static Transaction CreateTransaction(System.Transactions.Transaction ambient)
        {
            ambient.TransactionCompleted += OnAmbientTransactionCompleted;

            return new Transaction(ambient, true);
        }

        private static void OnAmbientTransactionCompleted(object sender, System.Transactions.TransactionEventArgs e)
        {
            e.Transaction.TransactionCompleted -= OnAmbientTransactionCompleted;
            RemoveTransaction(e.Transaction);
        }
    }
}
