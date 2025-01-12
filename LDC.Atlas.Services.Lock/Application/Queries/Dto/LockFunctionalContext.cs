﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDC.Atlas.Services.Lock.Application.Queries.Dto
{
    public enum LockFunctionalContext
    {
        TradeEdit = 100,
        RelativeTradeEdit = 101,
        TradeApproval = 102,
        TradeSplit = 103,
        TradeTranche = 104,
        RelativeTradeSplit = 105,
        RelativeTradeTranche = 106,
        TradeAssignment = 107,
        TradeDeassignment = 108,
        BulkEdition = 109,
        BulkApproval = 110,
        TradeMerge = 112,
        TradeBulkClosure = 113,
        FxDeal = 114,
        CharterEdit = 200,
        CharterDeletion = 201,
        CharterBulkClosure = 202,
        ContractInvoicing = 300,
        CostInvoicing = 301,
        GoodsAndCostsInvoicing = 302,
        WashoutInvoicing = 303,
        ReversalInvoicing = 304,
        Allocation = 400,
        RelativeAllocation = 401,
        Deallocation = 402,
        BulkAllocation = 403,
        BulkDeallocation = 404,
        RelativeDeallocation = 403,
        CostMatrixEdition = 500,
        CostMatrixDeletion = 501,
        MasterDataEdition = 600,
        UserAccountEdition = 700,
        UserAccountDeletion = 701,
        UserProfileEdition = 800,
        UserProfileDeletion = 801,
        AccountingDocumentEdition = 900,
        AccountingDocumentAuthorizeForPosting = 901,
        AccountingDocumentReversal = 902,
        CashDocumentEdition = 1000,
        CashDocumentDeletion = 1001,
    }
}
