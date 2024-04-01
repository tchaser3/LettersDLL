/* Title:           Letters Class
 * Date:            10-4-17
 * Author:          Terry Holmes
 * 
 * Description:     This the class for the letters table */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace LettersDLL
{
    public class LettersClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        LettersDataSet aLettersDataSet;
        LettersDataSetTableAdapters.lettersTableAdapter aLettersTableAdapter;

        InsertLetterEntryTableAdapters.QueriesTableAdapter aInsertLetterTableAdapter;

        FindLetterByDescriptionDataSet aFindLetterByDescriptionDataSet;
        FindLetterByDescriptionDataSetTableAdapters.FindLetterByDescriptionTableAdapter aFindLetterByDescriptionTableAdapter;

        FindLettersByLetterIDDataSet aFindLettersByLetterIDDataSet;
        FindLettersByLetterIDDataSetTableAdapters.FindLettersByLetterIDTableAdapter aFindLettersByLettersIDTableAdapter;

        FindLetterByDateMatchDataSet aFindLetterByDateMatchDataSet;
        FindLetterByDateMatchDataSetTableAdapters.FindLetterByDateMatchTableAdapter aFindLetterByDateMatchTableAdapter;

        LetterParagraphDataSet aLetterParagraphDataSet;
        LetterParagraphDataSetTableAdapters.letterparagraphTableAdapter aLetterParagraphTableAdpater;

        InsertParagraphEntryTableAdapters.QueriesTableAdapter aInsertParagraphTableAdapter;

        UpdateLetterParagraphEntryTableAdapters.QueriesTableAdapter aUpdateLetterParagraphTableAdapter;

        FindLetterParagraphByDescriptionDataSet aFindLetterParagraphByDescriptionDataSet;
        FindLetterParagraphByDescriptionDataSetTableAdapters.FindLetterParagraphByDescriptionTableAdapter aFindLetterParagraphByDescriptionTableAdapter;

        FindLetterParagraphByLetterIDDataSet aFindLetterParagraphByLetterIDDataSet;
        FindLetterParagraphByLetterIDDataSetTableAdapters.FindLetterParagraphByLetterIDTableAdapter aFindLetterParagraphByLetterIDTableAdapter;

        LetterParagraphHistoryDataSet aLetterParagraphHistoryDataSet;
        LetterParagraphHistoryDataSetTableAdapters.letterparagraphhistoryTableAdapter aLetterParagraphHistoryTableAdapter;

        InsertLetterParagraphHistoryEntryTableAdapters.QueriesTableAdapter aInsertLetterParagraphHistoryTableAdpater;

        FindLetterParagraphHistoryByDescriptionDataSet aFindLetterParagraphHistoryByDescriptionDataSet;
        FindLetterParagraphHistoryByDescriptionDataSetTableAdapters.FindLetterParagraphHistoryByDescriptionTableAdapter aFindLetterParagraphHistoryByDescriptionTableAdapter;

        FindLetterParagraphHistoryByLetterIDDataSet aFindLetterParagraphHistoryByLetterIDDataSet;
        FindLetterParagraphHistoryByLetterIDDataSetTableAdapters.FindLetterParagraphHistoryByLetterIDTableAdapter aFindLetterParagraphHistoryByLetterIDTableAdapter;

        FindSortedLettersDataSet aFindSortedLettersDataSet;
        FindSortedLettersDataSetTableAdapters.FindSortedLettersTableAdapter aFindSortedLettersTableAdapter;

        public FindSortedLettersDataSet FindSortedLetters()
        {
            try
            {
                aFindSortedLettersDataSet = new FindSortedLettersDataSet();
                aFindSortedLettersTableAdapter = new FindSortedLettersDataSetTableAdapters.FindSortedLettersTableAdapter();
                aFindSortedLettersTableAdapter.Fill(aFindSortedLettersDataSet.FindSortedLetters);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Sorted Letters " + Ex.Message);
            }

            return aFindSortedLettersDataSet;
        }
        public FindLetterParagraphHistoryByLetterIDDataSet FindLetterParagraphHistoryByLetterID(int intLetterID)
        {
            try
            {
                aFindLetterParagraphHistoryByLetterIDDataSet = new FindLetterParagraphHistoryByLetterIDDataSet();
                aFindLetterParagraphHistoryByLetterIDTableAdapter = new FindLetterParagraphHistoryByLetterIDDataSetTableAdapters.FindLetterParagraphHistoryByLetterIDTableAdapter();
                aFindLetterParagraphHistoryByLetterIDTableAdapter.Fill(aFindLetterParagraphHistoryByLetterIDDataSet.FindLetterParagraphHistoryByLetterID, intLetterID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter Paragraph History By Letter ID " + Ex.Message);
            }

            return aFindLetterParagraphHistoryByLetterIDDataSet;
        }
        public FindLetterParagraphHistoryByDescriptionDataSet FindLetterParagraphHistoryByDescription(string strLetterDescription)
        {
            try
            {
                aFindLetterParagraphHistoryByDescriptionDataSet = new FindLetterParagraphHistoryByDescriptionDataSet();
                aFindLetterParagraphHistoryByDescriptionTableAdapter = new FindLetterParagraphHistoryByDescriptionDataSetTableAdapters.FindLetterParagraphHistoryByDescriptionTableAdapter();
                aFindLetterParagraphHistoryByDescriptionTableAdapter.Fill(aFindLetterParagraphHistoryByDescriptionDataSet.FindLetterParagraphHistoryByDescription, strLetterDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter Paragraph History By Description " + Ex.Message);
            }

            return aFindLetterParagraphHistoryByDescriptionDataSet;
        }
        public bool InsertLetterParagraphHistory(int intLetterID, int intParagraphID, int intParagraphHistory, int intParagraphNumber, string strParagraphText, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertLetterParagraphHistoryTableAdpater = new InsertLetterParagraphHistoryEntryTableAdapters.QueriesTableAdapter();
                aInsertLetterParagraphHistoryTableAdpater.InsertLetterParagraphHistory(intLetterID, intParagraphID, intParagraphNumber, strParagraphText, DateTime.Now, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Insert Letter Paragraph History " + Ex.Message);
            }

            return blnFatalError;
        }
        public LetterParagraphHistoryDataSet GetLetterParagraphHistoryInfo()
        {
            try
            {
                aLetterParagraphHistoryDataSet = new LetterParagraphHistoryDataSet();
                aLetterParagraphHistoryTableAdapter = new LetterParagraphHistoryDataSetTableAdapters.letterparagraphhistoryTableAdapter();
                aLetterParagraphHistoryTableAdapter.Fill(aLetterParagraphHistoryDataSet.letterparagraphhistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Get Letter Paragraph History Info " + Ex.Message);
            }

            return aLetterParagraphHistoryDataSet;
        }
        public void UpdateLetterParagraphHistoryDB(LetterParagraphHistoryDataSet aLetterParagraphHistoryDataSet)
        {
            try
            {
                aLetterParagraphHistoryTableAdapter = new LetterParagraphHistoryDataSetTableAdapters.letterparagraphhistoryTableAdapter();
                aLetterParagraphHistoryTableAdapter.Update(aLetterParagraphHistoryDataSet.letterparagraphhistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Update Letter Paragraph History DB " + Ex.Message);
            }
        }
        public FindLetterParagraphByLetterIDDataSet FindLetterParagraphByLetterID(int intLetterID)
        {
            try
            {
                aFindLetterParagraphByLetterIDDataSet = new FindLetterParagraphByLetterIDDataSet();
                aFindLetterParagraphByLetterIDTableAdapter = new FindLetterParagraphByLetterIDDataSetTableAdapters.FindLetterParagraphByLetterIDTableAdapter();
                aFindLetterParagraphByLetterIDTableAdapter.Fill(aFindLetterParagraphByLetterIDDataSet.FindLetterParagraphByLetterID, intLetterID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter Paragraph By Letter ID " + Ex.Message);
            }

            return aFindLetterParagraphByLetterIDDataSet;
        }
        public FindLetterParagraphByDescriptionDataSet FindLetterParagraphByDescription(string strLetterDescription)
        {
            try
            {
                aFindLetterParagraphByDescriptionDataSet = new FindLetterParagraphByDescriptionDataSet();
                aFindLetterParagraphByDescriptionTableAdapter = new FindLetterParagraphByDescriptionDataSetTableAdapters.FindLetterParagraphByDescriptionTableAdapter();
                aFindLetterParagraphByDescriptionTableAdapter.Fill(aFindLetterParagraphByDescriptionDataSet.FindLetterParagraphByDescription, strLetterDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter Paragraph By Description " + Ex.Message);
            }

            return aFindLetterParagraphByDescriptionDataSet;
        }
        public bool UpdateParagraph(int intParagraphID, int intParagraphNumber, string strParagraphText, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateLetterParagraphTableAdapter = new UpdateLetterParagraphEntryTableAdapters.QueriesTableAdapter();
                aUpdateLetterParagraphTableAdapter.UpdateLetterParagraph(intParagraphID, intParagraphNumber, strParagraphText, DateTime.Now, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Insert Paragraph " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertParagraph(int intParagraphNumber, int intLetterID, string strParagraphText, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertParagraphTableAdapter = new InsertParagraphEntryTableAdapters.QueriesTableAdapter();
                aInsertParagraphTableAdapter.InsertParagraph(intParagraphNumber, intLetterID, strParagraphText, DateTime.Now, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Insert Paragraph " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public LetterParagraphDataSet GetLetterParagraphInfo()
        {
            try
            {
                aLetterParagraphDataSet = new LetterParagraphDataSet();
                aLetterParagraphTableAdpater = new LetterParagraphDataSetTableAdapters.letterparagraphTableAdapter();
                aLetterParagraphTableAdpater.Fill(aLetterParagraphDataSet.letterparagraph);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Get Letter Paragraph Info " + Ex.Message);
            }

            return aLetterParagraphDataSet;
        }
        public void UpdateLetterParagrapDB(LetterParagraphDataSet aLetterParagraphDataSet)
        {
            try
            {
                aLetterParagraphTableAdpater = new LetterParagraphDataSetTableAdapters.letterparagraphTableAdapter();
                aLetterParagraphTableAdpater.Update(aLetterParagraphDataSet.letterparagraph);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // UPdate Letter Paragraph DB " + Ex.Message);
            }
        }
        public FindLetterByDateMatchDataSet FindLetterByDateMatch(DateTime datLetterDate)
        {
            try
            {
                aFindLetterByDateMatchDataSet = new FindLetterByDateMatchDataSet();
                aFindLetterByDateMatchTableAdapter = new FindLetterByDateMatchDataSetTableAdapters.FindLetterByDateMatchTableAdapter();
                aFindLetterByDateMatchTableAdapter.Fill(aFindLetterByDateMatchDataSet.FindLetterByDateMatch, datLetterDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter By Date Match " + Ex.Message);
            }

            return aFindLetterByDateMatchDataSet;
        }
        public FindLettersByLetterIDDataSet FindLettersByLetterID(int intLetterID)
        {
            try
            {
                aFindLettersByLetterIDDataSet = new FindLettersByLetterIDDataSet();
                aFindLettersByLettersIDTableAdapter = new FindLettersByLetterIDDataSetTableAdapters.FindLettersByLetterIDTableAdapter();
                aFindLettersByLettersIDTableAdapter.Fill(aFindLettersByLetterIDDataSet.FindLettersByLetterID, intLetterID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letters By Letter ID " + Ex.Message);
            }

            return aFindLettersByLetterIDDataSet;
        }
        public FindLetterByDescriptionDataSet FindLetterByDescription(string strLetterDescription)
        {
            try
            {
                aFindLetterByDescriptionDataSet = new FindLetterByDescriptionDataSet();
                aFindLetterByDescriptionTableAdapter = new FindLetterByDescriptionDataSetTableAdapters.FindLetterByDescriptionTableAdapter();
                aFindLetterByDescriptionTableAdapter.Fill(aFindLetterByDescriptionDataSet.FindLetterByDescription, strLetterDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Find Letter By Description " + Ex.Message);
            }

            return aFindLetterByDescriptionDataSet;
        }
        public bool InsertLetter(string strLetterDescription, DateTime datLetterDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertLetterTableAdapter = new InsertLetterEntryTableAdapters.QueriesTableAdapter();
                aInsertLetterTableAdapter.InsertLetter(strLetterDescription, datLetterDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Insert Letter " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public LettersDataSet GetLettersInfo()
        {
            try
            {
                aLettersDataSet = new LettersDataSet();
                aLettersTableAdapter = new LettersDataSetTableAdapters.lettersTableAdapter();
                aLettersTableAdapter.Fill(aLettersDataSet.letters);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Get Letters Info " + Ex.Message);
            }

            return aLettersDataSet;
        }
        public void UpdateLettersDB(LettersDataSet aLettersDataSet)
        {
            try
            {
                aLettersTableAdapter = new LettersDataSetTableAdapters.lettersTableAdapter();
                aLettersTableAdapter.Update(aLettersDataSet.letters);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Letters Class // Update Letters DB " + Ex.Message);
            }
        }
    }
}
