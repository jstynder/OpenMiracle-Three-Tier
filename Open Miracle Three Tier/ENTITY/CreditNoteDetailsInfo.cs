using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;
//<summary>    
//Summary description for CreditNoteDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class CreditNoteDetailsInfo    
{    
    private decimal _creditNoteDetailsId;    
    private decimal _creditNoteMasterId;    
    private decimal _ledgerId;
    
    private decimal _credit;
    private decimal _debit;
    private decimal _exchangeRateId;
    private string _chequeNo;
    private DateTime _chequeDate;
     
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal CreditNoteDetailsId    
    {    
        get { return _creditNoteDetailsId; }    
        set { _creditNoteDetailsId = value; }    
    }    
    public decimal CreditNoteMasterId    
    {    
        get { return _creditNoteMasterId; }    
        set { _creditNoteMasterId = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public decimal Debit    
    {    
        get { return _debit; }
        set { _debit = value; }    
       
    }

    public decimal Credit
    {
        get { return _credit; }
        set { _credit = value; }
    
    }
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }

    }

    public string ChequeNo
    {
        get { return _chequeNo; }
        set { _chequeNo = value; }
    }
    public DateTime ChequeDate
    {
        get { return _chequeDate; }
        set { _chequeDate = value; }
    }


    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    
}    
}
