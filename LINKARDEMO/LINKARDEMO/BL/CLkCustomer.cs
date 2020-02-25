using LinkarClient;
using LinkarCommon;
using System.Collections.Generic;

namespace LINKARDEMO
{
    public class CLkCustomer : LinkarMainClass
    {
        #region Properties

        //The copy of the client for operations
        LinkarClt _LinkarClt = null;

        //The name for the file in the Database
        public static string FILE_CLkCustomer = "LK.CUSTOMERS";

        #region CODE

        private string _Code;

        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
                OnPropertyChanged("Code");
            }
        }

        public static string DICT_Code()
        {
            return "CODE";
        }

        #endregion

        #region NAME

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public static string DICT_Name()
        {
            return "NAME";
        }

        #endregion

        #region ADDRESS

        private string _Address;

        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
                OnPropertyChanged("Address");
            }
        }

        public static string DICT_Address()
        {
            return "ADDR";
        }

        #endregion

        #region PHONE

        private string _Phone;

        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public static string DICT_Phone()
        {
            return "PHONE";
        }

        #endregion

        #endregion

        #region Contructors

        /// <summary>
        /// Build the object
        /// </summary>
        /// <param name="linkarClt">Copy of client</param>
        public CLkCustomer(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
        }

        /// <summary>
        /// Build the object
        /// </summary>
        /// <param name="linkarClt">Copy of client</param>
        /// <param name="isNew">Set status</param>
        public CLkCustomer(LinkarClt linkarClt, bool isNew)
        {
            _LinkarClt = linkarClt;
            if (isNew)
                Status = StatusTypes.NEW;
        }

        #endregion

        #region Import / Export

        /// <summary>
        /// Fill the record from QM raw strings
        /// </summary>
        /// <param name="recordID">Code of record</param>
        /// <param name="record">Buffer of data</param>
        /// <param name="recordCalculated">Buffer of calculated fields</param>
        public void GetRecord(string recordID, string record, string recordCalculated)
        {
            //Create empty record
            string[] reg = new string[3];
            for (int j = 0; j < reg.Length; j++)
                reg[j] = "";

            //Fill the record
            if (record != null && record != "")
            {
                string[] aux = record.Split(DBMV_Mark.AM);
                for (int j = 0; j < aux.Length; j++)
                    reg[j] = aux[j];
            }

            //Create empty calculated record
            string[] regI = new string[0];
            for (int k = 0; k < regI.Length; k++)
                regI[k] = "";

            //Fill the calculated record
            if (recordCalculated != null && recordCalculated != "")
            {
                string[] auxI = recordCalculated.Split(DBMV_Mark.AM);
                int k = 0;
                for (; k < auxI.Length; k++)
                    regI[k] = auxI[k];
            }

            //Fill the record ID property
            Code = recordID;
            if (record == null || record == "")
                return;

            //Fill the class properties
            Name = LinkarDataTypes.GetAlpha(reg[0]);
            Address = LinkarDataTypes.GetAlpha(reg[1]);
            Phone = LinkarDataTypes.GetAlpha(reg[2]);

        }

        /// <summary>
        /// Export the record to a QM raw strings
        /// </summary>
        /// <returns>Buffer of data</returns>
        public string SetRecord()
        {
            //Create empty record
            string record = "";
            string[] reg = new string[3];

            //Get the class properties
            LinkarDataTypes.SetAlpha(ref reg[0], Name);
            LinkarDataTypes.SetAlpha(ref reg[1], Address);
            LinkarDataTypes.SetAlpha(ref reg[2], Phone);

            //Generate LkString
            record = string.Join((DBMV_Mark.AM_str), reg);
            return record;
        }

        #endregion

        #region CRUD

        /// <summary>
        /// READ record
        /// </summary>
        /// <param name="calculated">Get calculated fields</param>
        /// <param name="fileName">Name of file</param>
        public void ReadRecord(bool calculated, string fileName)
        {
            //Fill the Read options
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            bool dictionaries = false;
            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            ReadOptions readOptions = new ReadOptions(calculated, conversion, formatSpec, originalRecords, dictionaries);
            string customVars = "";
            //Call to sincronous session version of Read function
            string lkstring = _LinkarClt.Read_Text(fileName, _Code, "", readOptions, DATAFORMAT_TYPE.MV, customVars, 0);
            char delimiter = ASCII_Chars.FS_chr;
            char delimiterThisList = DBMV_Mark.AM;
            string records = "";
            string recordCalculateds = "";
            string[] parts = lkstring.Split(delimiter);
            if (parts.Length >= 1)
            {
                string[] ThisList = parts[0].Split(delimiterThisList);
                int numElements = ThisList.Length;
                for (int i = 1; i < numElements; i++)
                {
                    if (ThisList[i].Equals("RECORD"))
                    {
                        records = parts[i];
                    }
                    if (ThisList[i].Equals("CALCULATED"))
                    {
                        recordCalculateds = parts[i];
                    }
                    if (ThisList[i].Equals("ERRORS"))
                    {
                        if (parts[i] != null && parts[i].Length > 0)
                            this.LstErrors = new List<string>(parts[i].Split(DBMV_Mark.AM));
                        else
                            this.LstErrors = new List<string>();
                    }
                }
            }

            //Fill the class with response data
            if (records != null && records != "")
                this.GetRecord(this._Code, records, recordCalculateds);
        }

        /// <summary>
        /// NEW record
        /// </summary>
        /// <param name="fileName">Name of File</param>
        public void NewRecord(string fileName)
        {
            //Fill the New options
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            bool readAfter = true;
            bool calculated = false;
            bool dictionaries = false;
            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;

            bool active_RecordIdTypeLinkar = false;
            bool active_RecordIdTypeRandom = false;
            bool active_RecordIdTypeCustom = false;

            string prefix = "";
            string separator = "";
            string formatSpecTxt = "";
            bool numeric = false;
            int Length = 0;

            RecordIdType recordIdType;
            if (active_RecordIdTypeLinkar)
                recordIdType = new RecordIdType(prefix, separator, formatSpecTxt);
            else if (active_RecordIdTypeRandom)
                recordIdType = new RecordIdType(numeric, Length);
            else if (active_RecordIdTypeCustom)
                recordIdType = new RecordIdType(true);
            else
                recordIdType = new RecordIdType();
            NewOptions NewOptions = new NewOptions(recordIdType, readAfter, calculated, conversion, formatSpec, originalRecords, dictionaries);

            string customVars = "";
            string inputRecords = this.SetRecord();

            //Call to sincronous session version of New function
            string lkstring = _LinkarClt.New_Text(fileName, _Code, inputRecords, NewOptions, DATAFORMAT_TYPE.MV, DATAFORMAT_TYPE.MV, customVars, 0);

            char delimiter = ASCII_Chars.FS_chr;
            char delimiterThisList = DBMV_Mark.AM;
            string recordIds = "";
            string records = "";
            string recordCalculateds = "";
            string[] parts = lkstring.Split(delimiter);
            if (parts.Length >= 1)
            {
                string[] ThisList = parts[0].Split(delimiterThisList);
                int numElements = ThisList.Length;
                for (int i = 1; i < numElements; i++)
                {
                    if (ThisList[i].Equals("RECORD_ID"))
                    {
                        recordIds = parts[i];
                    }
                    if (ThisList[i].Equals("RECORD"))
                    {
                        records = parts[i];
                    }
                    if (ThisList[i].Equals("CALCULATED"))
                    {
                        recordCalculateds = parts[i];
                    }
                    if (ThisList[i].Equals("ERRORS"))
                    {
                        if (parts[i] != null && parts[i].Length > 0)
                            this.LstErrors = new List<string>(parts[i].Split(DBMV_Mark.AM));
                        else
                            this.LstErrors = new List<string>();
                    }
                }
            }

            //Fill the class with response data
            if (records != null && records != "")
                this.GetRecord(!string.IsNullOrEmpty(recordIds) ? recordIds : this._Code, records, recordCalculateds);
        }

        /// <summary>
        /// WRITE record
        /// </summary>
        /// <param name="fileName">Name of file</param>
        public void WriteRecord(string fileName)
        {
            //Fill the Update options
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            bool optimisticLockControl = false;
            bool readAfter = false;
            bool calculated = false;
            bool dictionaries = false;
            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            UpdateOptions UpdateOptions = new UpdateOptions(optimisticLockControl, readAfter, calculated, conversion, formatSpec, originalRecords, dictionaries);

            string customVars = "";
            string inputRecords = this.SetRecord();
            //Call to sincronous session version of Update function
            string lkstring = _LinkarClt.Update_Text(fileName, _Code, inputRecords, UpdateOptions, this.RecordOriginalContent, DATAFORMAT_TYPE.MV, DATAFORMAT_TYPE.MV, customVars, 0);

            char delimiter = ASCII_Chars.FS_chr;
            char delimiterThisList = DBMV_Mark.AM;
            string records = "";
            string recordCalculateds = "";
            string[] parts = lkstring.Split(delimiter);
            if (parts.Length >= 1)
            {
                string[] ThisList = parts[0].Split(delimiterThisList);
                int numElements = ThisList.Length;
                for (int i = 1; i < numElements; i++)
                {
                    if (ThisList[i].Equals("RECORD"))
                    {
                        records = parts[i];
                    }
                    if (ThisList[i].Equals("CALCULATED"))
                    {
                        recordCalculateds = parts[i];
                    }
                    if (ThisList[i].Equals("ERRORS"))
                    {
                        if (parts[i] != null && parts[i].Length > 0)
                            this.LstErrors = new List<string>(parts[i].Split(DBMV_Mark.AM));
                        else
                            this.LstErrors = new List<string>();
                    }
                }
            }

            //Fill the class with response data
            if (records != null && records != "")
                this.GetRecord(this._Code, records, recordCalculateds);
        }

        /// <summary>
        /// DELETE record
        /// </summary>
        /// <param name="fileName">Name of file</param>            
        public void DeleteRecord(string fileName)
        {
            //Fill the Delete options
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            bool optimisticLock = false;
            bool activeRecoverLinkar = false;
            string prefixRecoverLinkar = "";
            string separatorRecoverLinkar = "";
            bool activeRecoverCustom = false;

            RecoverIdType recoverIdType;
            if (activeRecoverLinkar)
                recoverIdType = new RecoverIdType(prefixRecoverLinkar, separatorRecoverLinkar);
            else if (activeRecoverCustom)
                recoverIdType = new RecoverIdType(true);
            else
                recoverIdType = new RecoverIdType();
            DeleteOptions deleteOptions = new DeleteOptions(optimisticLock, recoverIdType);

            string customVars = "";

            //Call to sincronous session version of Delete function
            string lkstring = _LinkarClt.Delete_Text(fileName, _Code, deleteOptions, this.RecordOriginalContent, DATAFORMAT_TYPE.MV, customVars, 0);

            char delimiter = ASCII_Chars.FS_chr;
            char delimiterThisList = DBMV_Mark.AM;
            string records = "";
            string recordCalculateds = "";
            string[] parts = lkstring.Split(delimiter);
            if (parts.Length >= 1)
            {
                string[] ThisList = parts[0].Split(delimiterThisList);
                int numElements = ThisList.Length;
                for (int i = 1; i < numElements; i++)
                {
                    if (ThisList[i].Equals("RECORD"))
                    {
                        records = parts[i];
                    }
                    if (ThisList[i].Equals("CALCULATED"))
                    {
                        recordCalculateds = parts[i];
                    }
                    if (ThisList[i].Equals("ERRORS"))
                    {
                        if (parts[i] != null && parts[i].Length > 0)
                            this.LstErrors = new List<string>(parts[i].Split(DBMV_Mark.AM));
                        else
                            this.LstErrors = new List<string>();
                    }
                }
            }

            //Fill the class with response data
            if (records != null && records != "")
                this.GetRecord(this._Code, records, recordCalculateds);
        }

        /// <summary>
        /// Cancel record changes
        /// </summary>
        public void RejectChanges()
        {
            if (Status != StatusTypes.NEW)
            {
                //Fill the class with the original data
                this.GetRecord(this.Code, this.RecordOriginalContent, this.RecordOriginalContentItypes);
                Status = StatusTypes.READED;
            }
        }

        #endregion
    }

    public class CLkCustomers : List<CLkCustomer>
    {
        //The copy of the client for operations
        public LinkarClt _LinkarClt = null;

        //When use pagination this property have count of total records
        public double totalRecords = 0.0;

        public List<string> LstErrors;

        /// <summary>
        /// Build the object
        /// </summary>
        /// <param name="linkarClt">Copy of client</param>
        public CLkCustomers(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
        }

        #region Custom SELECTS

        /// <summary>
        /// Custom select operation
        /// </summary>
        /// <param name="sortClause">Sort Clause of query</param>
        /// <param name="var1">Code or name to select</param>
        /// <param name="numRegPag">Number of records per page</param>
        /// <param name="numPag">Number of page</param>
        /// <param name="fileName">Name of file</param>
        /// <param name="usingDict">Using other file dictionary</param>
        public void FindAll(string sortClause, string var1, int numRegPag, int numPag, string fileName, string usingDict)
        {
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            if (sortClause == null || sortClause == "")
                sortClause = "BY CODE";
            string selectClause = "";
            if (FormDemo.DataBaseType == "UniVerse")
                selectClause = "WITH CODE = \"" + var1 + "\" OR  WITH NAME LIKE \"..." + var1 + "...\"";
            else
                selectClause = "WITH CODE = \"" + var1 + "\" OR  WITH NAME = \"[" + var1 + "]\"";
            bool calculated = true;
            string dictionariesClause = "";
            dictionariesClause = "";
            string preSelectClause = "";
            this.SelectGeneric(selectClause, sortClause, preSelectClause, calculated, fileName, dictionariesClause, numRegPag, numPag, usingDict);
        }

        /// <summary>
        /// Select operation with all options
        /// </summary>
        /// <param name="selectClause">Select Clause of query</param>
        /// <param name="sortClause">Sort Clause of query</param>
        /// <param name="preSelectClause">Previous Select Clause of query</param>
        /// <param name="calculated">Get calculated files</param>
        /// <param name="fileName">Name of file</param>
        /// <param name="dictionariesClause">Dictionaries Clause of query</param>
        /// <param name="numRegPag">Number of records per page</param>
        /// <param name="numPag">Number of page</param>        
        /// <param name="usingDict">Using other file dictionary</param>
        public void SelectGeneric(string selectClause, string sortClause, string preSelectClause, bool calculated,
            string fileName, string dictionariesClause, int numRegPag, int numPag, string usingDict)
        {
            //Fill the Select options
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            bool dictionaries = false;
            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            bool onlyRecordId = false;
            bool pagination = false;
            SelectOptions selectOptions = new SelectOptions(onlyRecordId, pagination, numRegPag, numPag, calculated, conversion, formatSpec, originalRecords, dictionaries);

            //Call to sincronous session version of Select function
            string lkstring = _LinkarClt.Select_Text(fileName, selectClause, sortClause, dictionariesClause, preSelectClause, selectOptions, DATAFORMAT_TYPE.MV, "", 0);
            this.Clear();
            if (!string.IsNullOrEmpty(lkstring))
            {
                char delimiter = ASCII_Chars.FS_chr;
                char delimiterThisList = DBMV_Mark.AM;
                string recordIds = "";
                string records = "";
                string recordCalculateds = "";
                string[] parts = lkstring.Split(delimiter);
                if (parts.Length >= 1)
                {
                    string[] ThisList = parts[0].Split(delimiterThisList);
                    int numElements = ThisList.Length;
                    for (int i = 1; i < numElements; i++)
                    {
                        if (ThisList[i].Equals("RECORD_ID"))
                        {
                            recordIds = parts[i];
                        }
                        if (ThisList[i].Equals("RECORD"))
                        {
                            records = parts[i];
                        }
                        if (ThisList[i].Equals("CALCULATED"))
                        {
                            recordCalculateds = parts[i];
                        }
                        if (ThisList[i].Equals("ERRORS"))
                        {
                            if (parts[i] != null && parts[i].Length > 0)
                                this.LstErrors = new List<string>(parts[i].Split(DBMV_Mark.AM));
                            else
                                this.LstErrors = new List<string>();
                        }
                    }
                }

                //Fill all the records with response data
                string[] lstids = recordIds.Split(ASCII_Chars.RS_chr);
                string[] lstregs = records.Split(ASCII_Chars.RS_chr);
                string[] lstcalcs = recordCalculateds.Split(ASCII_Chars.RS_chr);

                for (int i = 0; i < lstids.Length; i++)
                {
                    CLkCustomer record = new CLkCustomer(_LinkarClt);
                    record.RecordOriginalContent = lstregs[i];
                    if (recordCalculateds != null && recordCalculateds != "")
                    {
                        record.RecordOriginalContentItypes = lstcalcs[i];
                        record.GetRecord(lstids[i], lstregs[i], lstcalcs[i]);
                    }
                    else
                        record.GetRecord(lstids[i], lstregs[i], "");

                    if (this.LstErrors != null && this.LstErrors.Count > 0)
                    {
                        for (int j = 0; j < this.LstErrors.Count; j++)
                        {
                            if (!string.IsNullOrEmpty(this.LstErrors[i]))
                            {
                                string[] errorParts = this.LstErrors[i].Split(DBMV_Mark.VM);
                                if (errorParts.Length > 2 && errorParts[2] == record.Code)
                                    record.LstErrors.Add(this.LstErrors[i]);
                            }
                        }
                    }

                    record.Status = LinkarMainClass.StatusTypes.READED;
                    this.Add(record);
                }
            }
        }

        /// <summary>
        /// Select all records operation
        /// </summary>
        /// <param name="sortClause">Sort Clause of query</param>
        /// <param name="fileName">Name of file</param>
        /// <param name="numRegPag">Number of records per page</param>
        /// <param name="numPag">Number of page</param>
        public void SelectAll(string sortClause, string fileName, int numRegPag, int numPag)
        {
            if (fileName == null || fileName == "")
                fileName = CLkCustomer.FILE_CLkCustomer;

            if (sortClause == null || sortClause == "")
                sortClause = "BY CODE";

            this.SelectGeneric("", sortClause, "", true, fileName, "", numRegPag, numPag, "");
        }

        #endregion
    }
}
