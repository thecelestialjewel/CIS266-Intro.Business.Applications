//Christine Jordan 10.6.2020
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Tuition_Application
{
    public static class Calculator
    {
        public static double CalculateTuition(int credits, ResidentStatuses residentStatus)
        {
            double tuitionRates;
            switch (residentStatus)
            {
                case ResidentStatuses.Resident:
                    if (credits <= 10)
                    {
                       tuitionRates = credits * 104.11;
                    }
                    else if (credits <= 18)
                    {
                        tuitionRates = 1041.10 + ((credits - 10) * 51.40);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 1452.30 +((credits- 18) *96.26);
                    }
                    break;
                case ResidentStatuses.NonResidentUS:
                    if (credits <= 10)
                    {
                        tuitionRates = credits * 117.11;
                    }
                    else if (credits <= 18)
                    {
                        tuitionRates = 1171.10 + ((credits - 10) * 52.09);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 1587.82 + ((credits - 18) * 96.26);
                    }
                    break;

                case ResidentStatuses.NonResidentNonUS:
                    if (credits <= 10)
                    {
                        tuitionRates = credits * 276.11;
                    }
                    else if (credits <= 18)
                    {
                        tuitionRates = 2761.10 + ((credits - 10) * 56.41);
                    }
                    else // 19 or more
                    {
                        tuitionRates = 3212.38 + ((credits - 18) * 268.26);
                    }
                    break;

                default:
                    tuitionRates = 0.0; // if not one of three Resident Status then 0.0
                    break;

            }
            return tuitionRates;
        }
    }
}
