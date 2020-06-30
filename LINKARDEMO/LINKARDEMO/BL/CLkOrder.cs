using LinkarClient;
using LinkarCommon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINKARDEMO
{
    public class CLkOrder : LinkarMainClass
    {
        #region Properties

        //The copy of the client for operations
        LinkarClt _LinkarClt = null;

        //The name for the file in the Database
        public static string FILE_CLkOrder = "LK.ORDERS";

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

        #region CUSTOMER

        private string _Customer;

        public string Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                _Customer = value;
                OnPropertyChanged("Customer");
            }
        }

        public static string DICT_Customer()
        {
            return "CUSTOMER";
        }

        #endregion

        #region DATE

        private string _Date;

        public DateTime? Date
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this._Date))
                {
                    int dias;
                    int.TryParse(this._Date, out dias);
                    return new DateTime(1967, 12, 31).AddDays(dias);
                }
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    int dias = ((DateTime)value - new DateTime(1967, 12, 31)).Days;

                    this._Date = dias.ToString();
                }
                else
                    this._Date = "";
                OnPropertyChanged("Date");
            }
        }

        public static string DICT_DateTime()
        {
            return "DATE";
        }

        #endregion

        #region ITOTALORDER

        private double _ITotalOrder;

        public double ITotalOrder
        {
            get
            {
                return _ITotalOrder;
            }
            set
            {
                _ITotalOrder = value;
                OnPropertyChanged("ITotalOrder");
            }
        }

        public static string DICT_ITotalOrder()
        {
            return "ITOTALORDER";
        }

        #endregion

        #region ICUSTOMERNAME

        private string _ICustomerName;

        public string ICustomerName
        {
            get
            {
                return _ICustomerName;
            }
            set
            {
                _ICustomerName = value;
                OnPropertyChanged("ICustomerName");
            }
        }

        public static string DICT_ICustomerName()
        {
            return "ICUSTOMERNAME";
        }

        #endregion

        #region LSTITEMS Multivalue list

        private List<MV_LstItems_CLkOrder> _LstLstItems;
        public List<MV_LstItems_CLkOrder> LstLstItems
        {
            get
            {
                return _LstLstItems;
            }
            set
            {
                if (_LstLstItems != null)
                {
                    _LstLstItems.Clear();
                    _LstLstItems = null;
                }
                _LstLstItems = value;
                OnPropertyChanged("LstLstItems");
            }
        }

        #endregion

        #endregion

        #region Contructores

        /// <summary>
        /// Build the object
        /// </summary>
        /// <param name="linkarClt">Copy of client</param>
        public CLkOrder(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
            _LstLstItems = new List<MV_LstItems_CLkOrder>();
        }

        /// <summary>
        /// Build the object
        /// </summary>
        /// <param name="linkarClt">Copy of client</param>
        /// <param name="isNew">Set status</param>
        public CLkOrder(LinkarClt linkarClt, bool isNew)
        {
            _LinkarClt = linkarClt;
            _LstLstItems = new List<MV_LstItems_CLkOrder>();
            if (isNew)
                Status = StatusTypes.NEW;
        }

        #endregion

        #region Import / Export

        /// <summary>
        /// Fill the record from QM raw strings
        /// </summary>
        /// <param name="recordID">Code of item</param>
        /// <param name="record">Buffer of data</param>
        /// <param name="recordCalculated">Buffer of calculated fields</param>
        public void GetRecord(string recordID, string record, string recordCalculated)
        {
            //Create empty record
            string[] reg = new string[7];
            for (int j = 0; j < reg.Length; j++)
                reg[j] = "";

            //Fill the record
            if (!string.IsNullOrEmpty(record))
            {
                string[] aux = record.Split(DBMV_Mark.AM);
                for (int j = 0; j < aux.Length; j++)
                    reg[j] = aux[j];
            }

            //Create empty calculated record
            string[] regI = new string[6];
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
            Customer = LinkarDataTypes.GetAlpha(reg[0]);
            this._Date = LinkarDataTypes.GetDateTime(reg[1]);
            OnPropertyChanged("Date");
            ITotalOrder = LinkarDataTypes.GetDecimal(regI[4]);
            ICustomerName = LinkarDataTypes.GetAlpha(regI[0]);

            #region Multivalues

            //Get the max number of multivalues dinamically
            int numMV_LstItems = 0;
            int tmpCountMV_LstItems = 0;
            tmpCountMV_LstItems = MvFunctions.LkDCount(reg[2], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(reg[3], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(reg[4], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(regI[3], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(regI[1], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(regI[2], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(reg[5], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;
            tmpCountMV_LstItems = MvFunctions.LkDCount(reg[6], DBMV_Mark.VM_str);
            if (tmpCountMV_LstItems > numMV_LstItems) numMV_LstItems = tmpCountMV_LstItems;

            //Iterate multivalues
            for (int i = 0; i < numMV_LstItems; i++)
            {
                if (i < this._LstLstItems.Count())
                    this._LstLstItems[i].GetRecord(this._LinkarClt, reg, regI, i);
                else
                {
                    MV_LstItems_CLkOrder regmv = new MV_LstItems_CLkOrder();
                    regmv.GetRecord(this._LinkarClt, reg, regI, i);
                    this._LstLstItems.Add(regmv);
                }
            }
            if (numMV_LstItems < this._LstLstItems.Count())
            {
                int offset = this._LstLstItems.Count() - numMV_LstItems;
                for (int i = 0; i < offset; i++)
                {
                    this._LstLstItems.RemoveAt(_LstLstItems.Count() - 1);
                }
            }

            #endregion

        }

        /// <summary>
        /// Export the record to a QM raw strings
        /// </summary>
        /// <returns>Buffer of data</returns>
        public string SetRecord()
        {
            //Create empty record
            string records = "";
            string[] reg = new string[7];

            //Get the class properties
            LinkarDataTypes.SetAlpha(ref reg[0], Customer);
            LinkarDataTypes.SetDateTime(ref reg[1], this._Date);

            #region Multivalues

            //Iterate multivalues
            if (this._LstLstItems != null)
            {
                int numMV_LstItems = this._LstLstItems.Count();
                for (int i = 0; i < numMV_LstItems; i++)
                    reg = this._LstLstItems[i].SetRecord(reg, i);
            }

            #endregion

            //Generate LkString
            records = string.Join((DBMV_Mark.AM_str), reg);
            return records;
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
                fileName = CLkOrder.FILE_CLkOrder;

            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            ReadOptions readOptions = new ReadOptions(calculated, conversion, formatSpec, originalRecords);
            string customVars = "";
            //Call to sincronous session version of Read function
            string lkstring = _LinkarClt.Read_Text(fileName, _Code, "", readOptions, DATAFORMATCRU_TYPE.MV, customVars, 0);

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
                fileName = CLkOrder.FILE_CLkOrder;

            bool readAfter = false;
            bool calculated = false;
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
            NewOptions NewOptions = new NewOptions(recordIdType, readAfter, calculated, conversion, formatSpec, originalRecords);

            string customVars = "";
            string inputRecords = this.SetRecord();

            //Call to sincronous session version of New function
            string lkstring = _LinkarClt.New_Text(fileName, _Code, inputRecords, NewOptions, DATAFORMAT_TYPE.MV, DATAFORMATCRU_TYPE.MV, customVars, 0);

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
        /// WRITE record
        /// </summary>
        /// <param name="fileName">Name of file</param>
        public void WriteRecord(string fileName)
        {
            //Fill the Update options
            if (fileName == null || fileName == "")
                fileName = CLkOrder.FILE_CLkOrder;

            bool optimisticLockControl = false;
            bool readAfter = false;
            bool calculated = false;
            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            UpdateOptions UpdateOptions = new UpdateOptions(optimisticLockControl, readAfter, calculated, conversion, formatSpec, originalRecords);

            string customVars = "";
            string inputRecords = this.SetRecord();
            //Call to sincronous session version of Update function
            string lkstring = _LinkarClt.Update_Text(fileName, _Code, inputRecords, UpdateOptions, this.RecordOriginalContent, DATAFORMAT_TYPE.MV, DATAFORMATCRU_TYPE.MV, customVars, 0);

            char delimiter = ASCII_Chars.FS_chr;
            char delimiterThisList = DBMV_Mark.AM;
            string records = "";
            string recordsCalculated = "";
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
                        recordsCalculated = parts[i];
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
                this.GetRecord(this._Code, records, recordsCalculated);
        }

        /// <summary>
        /// DELETE record
        /// </summary>
        /// <param name="fileName">Name of file</param>        
        public void DeleteRecord(string fileName)
        {
            //Fill the Delete options
            if (fileName == null || fileName == "")
                fileName = CLkOrder.FILE_CLkOrder;

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
            if (Status == StatusTypes.MODIFY || Status == StatusTypes.DELETED)
            {
                //Fill the class with the original data
                this.GetRecord(this.Code, this.RecordOriginalContent, this.RecordOriginalContentItypes);
                Status = StatusTypes.READED;
            }
        }

        #endregion
    }

    public class MV_LstItems_CLkOrder : LinkarClass
    {
        #region Properties

        #region ITEM

        private string _Item;

        public string Item
        {
            get
            {
                return _Item;
            }
            set
            {
                _Item = value;
                OnPropertyChanged("Item");
            }
        }

        public static string DICT_Item()
        {
            return "ITEM";
        }

        #endregion

        #region QTY

        private double _Qty;

        public double Qty
        {
            get
            {
                return _Qty;
            }
            set
            {
                _Qty = value;
                OnPropertyChanged("Qty");
            }
        }

        public static string DICT_Qty()
        {
            return "QTY";
        }

        #endregion

        #region PRICE

        private double _Price;

        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }

        public static string DICT_Price()
        {
            return "PRICE";
        }

        #endregion

        #region ITOTALLINE

        private double _ITotalLine;

        public double ITotalLine
        {
            get
            {
                return _ITotalLine;
            }
            set
            {
                _ITotalLine = value;
                OnPropertyChanged("ITotalLine");
            }
        }

        public static string DICT_ITotalLine()
        {
            return "ITOTALLINE";
        }

        #endregion

        #region IITEMDESCRIPTION

        private string _IItemDescription;

        public string IItemDescription
        {
            get
            {
                return _IItemDescription;
            }
            set
            {
                _IItemDescription = value;
                OnPropertyChanged("IItemDescription");
            }
        }

        public static string DICT_IItemDescription()
        {
            return "IITEMDESCRIPTION";
        }

        #endregion

        #region IITEMSTOCK

        private double _IItemStock;

        public double IItemStock
        {
            get
            {
                return _IItemStock;
            }
            set
            {
                _IItemStock = value;
                OnPropertyChanged("IItemStock");
            }
        }

        public static string DICT_IItemStock()
        {
            return "IITEMSTOCK";
        }

        #endregion

        #region LSTPARTIAL Multivalue list

        private List<SV_LstPartial_CLkOrder> _LstLstPartial;
        public List<SV_LstPartial_CLkOrder> LstLstPartial
        {
            get
            {
                return _LstLstPartial;
            }
            set
            {
                if (_LstLstPartial != null)
                {
                    _LstLstPartial.Clear();
                    _LstLstPartial = null;
                }
                _LstLstPartial = value;
                OnPropertyChanged("LstLstPartial");
            }
        }

        #endregion

        #endregion

        #region Contructors

        /// <summary>
        /// Build Multivalue list
        /// </summary>
        public MV_LstItems_CLkOrder()
        {
            _LstLstPartial = new List<SV_LstPartial_CLkOrder>();
        }

        #endregion

        #region Import / Export

        /// <summary>
        /// Fill the record Multivalues from QM raw strings
        /// </summary>
        /// <param name="_LinkarClt">Copy of client</param>
        /// <param name="reg">Buffer of data</param>
        /// <param name="regI">Buffer of calculated data</param>
        /// <param name="mvNumber">Number of multivalue</param>
        public void GetRecord(LinkarClt _LinkarClt, string[] reg, string[] regI, int mvNumber)
        {
            //Fill the class Multivalue properties
            Item = LinkarDataTypes.GetAlpha(reg[2], mvNumber);
            Qty = LinkarDataTypes.GetDecimal(reg[3], mvNumber);
            Price = LinkarDataTypes.GetDecimal(reg[4], mvNumber);
            ITotalLine = LinkarDataTypes.GetDecimal(regI[3], mvNumber);
            IItemDescription = LinkarDataTypes.GetAlpha(regI[1], mvNumber);
            IItemStock = LinkarDataTypes.GetDecimal(regI[2], mvNumber);

            #region Subvalues

            //Get the max number of subvalues dinamically
            int numSV_LstPartial = 0;
            int tmpCountSV_LstPartial = 0;
            tmpCountSV_LstPartial = MvFunctions.LkDCount(reg[5].Split(DBMV_Mark.VM)[mvNumber], DBMV_Mark.SM_str);
            if (tmpCountSV_LstPartial > numSV_LstPartial) numSV_LstPartial = tmpCountSV_LstPartial;
            tmpCountSV_LstPartial = MvFunctions.LkDCount(reg[6].Split(DBMV_Mark.VM)[mvNumber], DBMV_Mark.SM_str);
            if (tmpCountSV_LstPartial > numSV_LstPartial) numSV_LstPartial = tmpCountSV_LstPartial;

            //Iterate subvalues
            for (int i = 0; i < numSV_LstPartial; i++)
            {
                if (i < this._LstLstPartial.Count())
                    this._LstLstPartial[i].GetRecord(_LinkarClt, reg, regI, mvNumber, i);
                else
                {
                    SV_LstPartial_CLkOrder regsv = new SV_LstPartial_CLkOrder();
                    regsv.GetRecord(_LinkarClt, reg, regI, mvNumber, i);
                    this._LstLstPartial.Add(regsv);
                }
            }
            if (numSV_LstPartial < this._LstLstPartial.Count())
            {
                int offset = this._LstLstPartial.Count() - numSV_LstPartial;
                for (int i = 0; i < offset; i++)
                {
                    this._LstLstPartial.RemoveAt(_LstLstPartial.Count() - 1);
                }
            }

            #endregion

        }

        /// <summary>
        /// Export the record Multivalues to a QM raw strings
        /// </summary>
        /// <param name="reg">Buffer of data</param>
        /// <param name="mvNumber">Number of multivalue</param>
        /// <returns></returns>
        public string[] SetRecord(string[] reg, int mvNumber)
        {
            //Get the class Multivalue properties
            LinkarDataTypes.SetAlpha(ref reg[0], Item, mvNumber);
            LinkarDataTypes.SetDecimal(ref reg[1], Qty, -1, mvNumber);
            LinkarDataTypes.SetDecimal(ref reg[1], Price, -1, mvNumber);

            #region Subvalues

            //Iterate subvalues
            if (this._LstLstPartial != null)
            {
                int numSV_LstPartial = this._LstLstPartial.Count();
                for (int i = 0; i < numSV_LstPartial; i++)
                    reg = this._LstLstPartial[i].SetRecord(reg, mvNumber, i);
            }

            #endregion

            return reg;
        }

        #endregion
    }

    public class SV_LstPartial_CLkOrder : LinkarClass
    {
        #region Properties

        #region DELIVERYDATETIME

        private string _DeliveryDateTime;

        public DateTime? DeliveryDateTime
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this._DeliveryDateTime))
                {
                    int dias;
                    int.TryParse(this._DeliveryDateTime, out dias);
                    return new DateTime(1967, 12, 31).AddDays(dias);
                }
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    int dias = ((DateTime)value - new DateTime(1967, 12, 31)).Days;

                    this._DeliveryDateTime = dias.ToString();
                }
                else
                    this._DeliveryDateTime = "";
                OnPropertyChanged("DeliveryDateTime");
            }
        }

        public static string DICT_DeliveryDateTime()
        {
            return "DELIVERYDATE";
        }

        #endregion

        #region PARTIALQUANTITY

        private double _PartialQuantity;

        public double PartialQuantity
        {
            get
            {
                return _PartialQuantity;
            }
            set
            {
                _PartialQuantity = value;
                OnPropertyChanged("PartialQuantity");
            }
        }

        public static string DICT_PartialQuantity()
        {
            return "QTYPARTIAL";
        }

        #endregion

        #endregion

        #region Contructors

        /// <summary>
        /// Build Multivalue list
        /// </summary>
        public SV_LstPartial_CLkOrder()
        {

        }

        #endregion

        #region Import / Export

        /// <summary>
        /// Fill the record Subvalues from QM raw strings
        /// </summary>
        /// <param name="_LinkarClt">Copy of client</param>
        /// <param name="reg">Buffer of data</param>
        /// <param name="regI">Buffer of calculated data</param>
        /// <param name="mvNumber">Number of multivalue</param>
        /// <param name="svNumber">Number of subvalue</param>
        public void GetRecord(LinkarClt _LinkarClt, string[] reg, string[] regI, int mvNumber, int svNumber)
        {
            //Fill the class Multivalue properties
            this._DeliveryDateTime = LinkarDataTypes.GetDateTime(reg[5], mvNumber, svNumber);
            PartialQuantity = LinkarDataTypes.GetDecimal(reg[6], mvNumber, svNumber);
        }

        /// <summary>
        /// Export the record Subvalues to a QM raw strings
        /// </summary>
        /// <param name="reg">Buffer of data</param>
        /// <param name="mvNumber">Number of multivalue</param>
        /// <param name="svNumber">Number of subvalue</param>
        /// <returns></returns>
        public string[] SetRecord(string[] reg, int mvNumber, int svNumber)
        {
            //Get the class Subvalue properties
            LinkarDataTypes.SetDateTime(ref reg[5], this._DeliveryDateTime, mvNumber, -svNumber);
            LinkarDataTypes.SetDecimal(ref reg[6], PartialQuantity, -1, mvNumber, svNumber);

            return reg;
        }

        #endregion
    }

    public class CLkOrders : List<CLkOrder>
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
        public CLkOrders(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
        }

        #region Custom SELECTS

        /// <summary>
        /// Custom select operation
        /// </summary>
        /// <param name="sortClause">Sort Clause of query</param>
        /// <param name="var1">Code to select</param>
        /// <param name="numRegPag">Number of records per page</param>
        /// <param name="numPag">Number of page</param>
        /// <param name="fileName">Name of file</param>
        /// <param name="usingDict">Using other file dictionary</param>
        /// <param name="onlyIds">Get only ids</param>
        /// <param name="calculated">Get calculated files</param>
        /// <param name="pagination">Use pagination</param>
        public void FindAll(string sortClause, string var1, int numRegPag, int numPag, string fileName, string usingDict, bool onlyIds, bool calculated, bool pagination)
        {
            if (fileName == null || fileName == "")
                fileName = CLkOrder.FILE_CLkOrder;

            if (sortClause == null || sortClause == "")
                sortClause = "BY CODE";
            string selectClause = "";
            selectClause = "WITH CODE = \"" + var1 + "\"";
            string dictionariesClause = "";
            dictionariesClause = "";
            string preSelectClause = "";
            this.SelectGeneric(selectClause, sortClause, preSelectClause, calculated, fileName, dictionariesClause, numRegPag, numPag, usingDict, onlyIds, pagination);
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
        /// <param name="onlyIds">>Get only ids</param>
        /// <param name="pagination">Use pagination</param>
        public void SelectGeneric(string selectClause, string sortClause, string preSelectClause, bool calculated,
            string fileName, string dictionariesClause, int numRegPag, int numPag, string usingDict, bool onlyIds, bool pagination)
        {
            //Fill the Select options
            if (fileName == null || fileName == "")
                fileName = CLkOrder.FILE_CLkOrder;

            bool conversion = false;
            bool formatSpec = false;
            bool originalRecords = false;
            bool onlyRecordId = onlyIds;
            SelectOptions selectOptions = new SelectOptions(onlyRecordId, pagination, numRegPag, numPag, calculated, conversion, formatSpec, originalRecords);

            string ge = "";
            //Call to sincronous session version of Select function
            string lkstring = _LinkarClt.Select_Text(fileName, selectClause, sortClause, dictionariesClause, preSelectClause, selectOptions, DATAFORMATCRU_TYPE.MV, "", 0);

            this.Clear();

            if (!string.IsNullOrEmpty(lkstring))
            {
                char delimiter = ASCII_Chars.FS_chr;
                char delimiterThisList = DBMV_Mark.AM;
                string recordIds = "";
                string records = "";
                string recordcalculateds = "";
                string[] parts = lkstring.Split(delimiter);
                if (parts.Length >= 1)
                {
                    string[] ThisList = parts[0].Split(delimiterThisList);
                    int numElements = ThisList.Length;
                    for (int i = 1; i < numElements; i++)
                    {
                        if (ThisList[i].Equals("TOTAL_RECORDS"))
                        {
                            totalRecords = (string.IsNullOrEmpty(parts[i]) ? 0.0 : double.Parse(parts[i]));
                        }
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
                            recordcalculateds = parts[i];
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
                string[] lstcalculateds = recordcalculateds.Split(ASCII_Chars.RS_chr);

                for (int i = 0; i < lstids.Length; i++)
                {
                    CLkOrder record = new CLkOrder(_LinkarClt);

                    if (!string.IsNullOrEmpty(records))
                        record.RecordOriginalContent = lstregs[i];
                    if (recordcalculateds != null && recordcalculateds != "")
                    {
                        record.RecordOriginalContentItypes = lstcalculateds[i];
                        record.GetRecord(lstids[i], !string.IsNullOrEmpty(records) ? lstregs[i] : "", lstcalculateds[i]);
                    }
                    else
                        record.GetRecord(lstids[i], !string.IsNullOrEmpty(records) ? lstregs[i] : "", "");

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

                    record.Status = CLkOrder.StatusTypes.READED;
                    this.Add(record);
                }
            }
        }
        /// <summary>
        /// Select all records operation
        /// </summary>
        /// <param name="sortClause"></param>
        /// <param name="fileName"></param>
        /// <param name="numRegPag"></param>
        /// <param name="numPag"></param>
        /// <param name="onlyIds"></param>
        /// <param name="calculated"></param>
        /// <param name="pagination"></param>
        public void SelectAll(string sortClause, string fileName, int numRegPag, int numPag, bool onlyIds, bool calculated, bool pagination)
        {
            if (fileName == null || fileName == "")
                fileName = CLkOrder.FILE_CLkOrder;

            if (sortClause == null || sortClause == "")
                sortClause = "BY CODE";

            this.SelectGeneric("", sortClause, "", calculated, fileName, "", numRegPag, numPag, "", onlyIds, pagination);
        }

        #endregion
    }
}
