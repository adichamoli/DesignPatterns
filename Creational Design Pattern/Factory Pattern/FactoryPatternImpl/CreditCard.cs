using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImpl
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
