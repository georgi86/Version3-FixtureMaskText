using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixtureMaskText
{
    class ReportText
    {
        public static void RunPositiveReport(string ActualText)
        {
            Ranorex.Report.Success("Sucessfully performed: ", ActualText);
           
        }

        public static void RunNegativeReport(string ExpectedText, string ActualText)
        {
            Ranorex.Report.Error("STOP THE VERSION: ", ActualText);
            Ranorex.Report.Error("THE TEXT MUST BE: ", ExpectedText);
        }
    }



    class UtilityRun
    {
        public static void CompareTitleText(string Actual, string Hardcoded)
        {
            string ActualFixtureTitleText = Actual;
            string HardcodedFixtureTitleText = Hardcoded;
            bool bTitleText = true;

            bTitleText = ActualFixtureTitleText.CompareTo(HardcodedFixtureTitleText) == 0;

            if (bTitleText)
            {
                ReportText.RunPositiveReport(ActualFixtureTitleText);
            }
            else
            {
                ReportText.RunNegativeReport(ActualFixtureTitleText, HardcodedFixtureTitleText);
            }
        }
    }
}
