using BudgetApp.Models;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Coupons.Models;
using Coupons.Services;


namespace BudgetApp.Processes
{
    public static class Repository
    {
        static string path = TextReaderWriter.DBaseLocation;
        public static int intSumExpenses = 0;
        public static int intBudget;

        private static string budgetFile = "SetBudget.txt";
        private static string dealsFile = "Deals.txt";

        private static List<ExpensesModel> expenses = new List<ExpensesModel>();

        #region Budget
        public static void GetBudget()
        {
            try
            {
                string line = "";
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + budgetFile))
                {
                    while (true)
                    {
                        string[] arrayFileLine;
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            arrayFileLine = line.Split(TextReaderWriter.SeparatorValue);
                        }

                        bool boolSuccess = false;
                        int intAmt = 0;

                        boolSuccess = int.TryParse(arrayFileLine[1], out intAmt);
                        if (boolSuccess)
                        {
                            intBudget = intAmt;
                        }

                    }
                }
            }
            catch { }
        }

        public static void SaveBudget(int intAmt)
        {
            //GetBudget();  //Why get the budget? the value is not used here.

            // Append line to the file.
            using (var writer = new StreamWriter(path + TextReaderWriter.DirectorySeparator + budgetFile, false))//@"C:\programs\example.txt)
            {
                //intAmt *= -1;  //Don't understand why the budget needs to display on UI as a negative number.

                //intSumExpenses += intAmt;

                //intAmt += intBudget;

                writer.WriteLine("Budget" + TextReaderWriter.SeparatorValue + intAmt);
                
                intBudget = intAmt;
            }
        }

        #endregion

        #region Expenses
        public static int SumExpenses(string file, int intSumExp)
        {
            try
            {
                //Call Get Budget
                //GetBudget();

                string line = "";
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + file))
                {
                    intSumExpenses = 0; //initialize the sum of expenses

                    while (true)
                    {
                        string[] arrayFileLine;
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            arrayFileLine = line.Split(TextReaderWriter.SeparatorValue);
                        }

                        bool boolSuccess = false;
                        int intAmt = 0;

                        boolSuccess = int.TryParse(arrayFileLine[1], out intAmt);
                        if (boolSuccess)
                        {
                            intSumExpenses += intAmt;
                        }

                    }

                    //intSumExpenses += intBudget;
                }
            }
            catch { }

            intSumExp = intSumExpenses;

            return intSumExpenses;
        }
        
        //public static List<ClassName> GetExpense(string file)

        public static List<ExpensesModel> GetAllExpenses(string file)
        {
            try
            {
                intSumExpenses = 0; //initialize the sum

                string line = "";
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + file))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] arrayFileLine;
                        line = reader.ReadLine();
                       // var lines = File.ReadAllLines(file);
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            arrayFileLine = line.Split(TextReaderWriter.SeparatorValue);
                        }

                        expenses.Add(new ExpensesModel()
                        {
                            Item = arrayFileLine[0],
                            Value = double.Parse(arrayFileLine[1])
                        }); ; ; ;
                       // var sum = lines.Sum(ExpensesModel.Value=> int.TryParse(ExpensesModel.Value, out int x) ? x : 0);

                        //lvExpenseRecord.Items.Add(lvi);
                        //lvi.SubItems.Add(arrayFileLine[1]);

                        //bool boolSuccess = false;
                        //int intAmt = 0;

                        /*
                        boolSuccess = int.TryParse(arrayFileLine[1], out intAmt);
                        if (boolSuccess)
                        {
                            intSumExpenses += intAmt;
                        }
                        */
                    }
                }
            }
            catch { }

            return expenses;
        }
        public static ListView GetExpenses(string file, ListView lvExpenseRecord, out int intSumExp)
        {
            try
            {
                intSumExpenses = 0; //initialize the sum

                string line = "";
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + file))
                {
                    while (true)
                    {
                        string[] arrayFileLine;
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            arrayFileLine = line.Split(TextReaderWriter.SeparatorValue);
                        }

                        ListViewItem lvi = new ListViewItem(arrayFileLine[0]);
                        lvExpenseRecord.Items.Add(lvi);
                        lvi.SubItems.Add(arrayFileLine[1]);

                        bool boolSuccess = false;
                        int intAmt = 0;

                        boolSuccess = int.TryParse(arrayFileLine[1], out intAmt);
                        if (boolSuccess)
                        {
                            intSumExpenses += intAmt;
                        }

                    }
                }
            }
            catch { }
           
            intSumExp = intSumExpenses;

            return lvExpenseRecord;
        }

        public static void SaveExpenses(string file, string cat, string amt)
        {
            // Append line to the file.
            using (var writer = new StreamWriter(path + TextReaderWriter.DirectorySeparator + file, true))//@"C:\programs\example.txt)
            {
                writer.WriteLine(cat + TextReaderWriter.SeparatorValue + amt);
                bool boolSuccess = false;
                int intAmt = 0;
                boolSuccess = int.TryParse(amt, out intAmt);
                intSumExpenses += intAmt;
            }

        }
        #endregion

        #region Goals
        public static string GetGoal(string file)
        {
            string line = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + file))
                {
                    line = reader.ReadLine();
                }
            }
            catch { }

            return line;
        }

        public static void SaveGoal(string file, string goal)
        {
            // Append line to the file.
            using (var writer = new StreamWriter(path + TextReaderWriter.DirectorySeparator + file, false))
            {
                writer.WriteLine(goal);
            }

        }
        #endregion

        #region Deals
        public static List<CouponModel> GetDeals() //this is called in ViewDeals Load method on startup.
        {
            List<CouponModel> coupons = new List<CouponModel>();
            coupons = CouponService.GetCouponData();
            return coupons;
        }
        
        public static void SaveDeals(string strDealAmountDollars)
        {
            using (var writer = new StreamWriter(path + TextReaderWriter.DirectorySeparator + dealsFile, true))
            {
                writer.WriteLine(strDealAmountDollars);
            }
        }

        /// <summary>
        /// This routine GetDealsFromFile() is for the purpose of storing the deals obtained from View Deals but
        /// contributes toward the savings realized on the View Goal form in the txtGoalCompletion.Text (textbox).
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static double GetDealsFromFile()
        {
            string line = string.Empty;
            double dblDealsFromDBfile = 0.0;
            bool boolConversionSucess = false;

            try
            {
                using (StreamReader reader = new StreamReader(path + TextReaderWriter.DirectorySeparator + dealsFile))
                {
                    while (true)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        double dblAmt = 0.0;

                        boolConversionSucess = double.TryParse(line, out dblAmt);
                        if (boolConversionSucess == true)
                        {
                            dblDealsFromDBfile += dblAmt;
                        }
                    }
                }
                
            }
            catch { }

            return dblDealsFromDBfile;
        }
        #endregion
    }
}
