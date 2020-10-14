//Christine Jordan 10.13.2020
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.StudentTuitionCalculator
{
    
    public class Calculator
    {
        private const int standardCreditAmount = 10; //constants for credits
        private const int extraCreditAmount = 18;

        public int CreditAmount { get; private set; } //setting autoproperty
        
        public ResidentStatuses ResidentStatus { get; private set; }

        public string StudentID { get; private set; }

        public Calculator(string studentID, int numCredit, ResidentStatuses statuses)//constructor
        {
            StudentID = studentID;
            CreditAmount = numCredit;
            ResidentStatus = statuses;
        }

        public decimal CalculateTuition()
        {
            decimal tuitionRates;
            switch (ResidentStatus)
            {
                case ResidentStatuses.Resident:
                    if (CreditAmount <= standardCreditAmount)
                    {
                       tuitionRates = CreditAmount * 104.11m;
                    }
                    else if (CreditAmount <= extraCreditAmount)
                    {
                        tuitionRates = 1041.10m + ((CreditAmount - standardCreditAmount) * 51.40m);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 1452.30m +((CreditAmount- extraCreditAmount) *96.26m);
                    }
                    break;
                case ResidentStatuses.NonResidentUS:
                    if (CreditAmount <= standardCreditAmount)
                    {
                        tuitionRates = CreditAmount * 117.11m;
                    }
                    else if (CreditAmount <= extraCreditAmount)
                    {
                        tuitionRates = 1171.10m + ((CreditAmount - standardCreditAmount) * 52.09m);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 1587.82m + ((CreditAmount - extraCreditAmount) * 96.26m);
                    }
                    break;

                case ResidentStatuses.NonResidentNonUS:
                    if (CreditAmount <= standardCreditAmount)
                    {
                        tuitionRates = CreditAmount * 276.11m;
                    }
                    else if (CreditAmount <= extraCreditAmount)
                    {
                        tuitionRates = 2761.10m + ((CreditAmount - standardCreditAmount) * 56.41m);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 3212.38m + ((CreditAmount - extraCreditAmount) * 268.26m);
                    }
                    break;

                default:
                    tuitionRates = 0.0m; // if not one of three Resident Status then 0.0
                    break;

            }
            return tuitionRates;
        }
        public override string ToString()
        {
            return $"ID:[{StudentID}]-${CalculateTuition()}";
        }
    }
}
