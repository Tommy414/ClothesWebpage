﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            { return mCustomerList; }
            set
            { mCustomerList = value; }

        }
        public clsCustomer ThisCustomer
        {
            get
            { return mThisCustomer; }
            set
            { mThisCustomer = value; }

        }


        public int Count
        {
            get

            { return mCustomerList.Count; }

            set
            {
                //We shall worry about this later
            }


        }


        public clsCustomerCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);



        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("IsActive", mThisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@IsActive", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }



        public void ReportByEmail(string Email)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", Email);
            DB.Execute("sproc_tblCustomer_FilterByEmail");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
        }
    }

   
}