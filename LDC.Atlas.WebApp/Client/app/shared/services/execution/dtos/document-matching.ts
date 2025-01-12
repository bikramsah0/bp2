export class DocumentMatching {
    transactionDocumentId: string;
    transactionDocumentTypeId: number;
    accountReference: string;
    counterpartyId: number;
    clientName: string;
    lineId: number;
    documentReference: string;
    secondaryRef: string;
    departmentId: number;
    departmentCode: string;
    currencyCode: string;
    matchFlagId: number;
    markingId: number;
    documentDate: Date;
    valueDate: Date;
    costType: string;
    expenseCode: string;
    narrative: string;
    documentType: string;
    credit: number;
    debit: number;
    isMatched: boolean;
    balance: number;
    amount: number;
    totalCredit: number;
    totalDebit: number;
    isChecked: boolean;
    statutoryCcyAmount: number;
    functionalCcyAmount: number;
    currencyRoeType: string;
    rate: number;
    isCreditOrDebit: string;
    matchFlagCode: string;
    documentAmount: number;
    totalAmount: number;
    transactionDirectionId: number;
    transactiondocumentlist: number;
    revalTransactionDocumentId: number;
    originalRevaluationReference: string;
    paymentDocumentDate: Date;
    sourceJournalLineId: number;
    sourceInvoiceId: number;
    sourceCashLineId: number;
}
