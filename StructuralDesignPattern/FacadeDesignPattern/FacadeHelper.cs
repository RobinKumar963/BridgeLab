// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FacadeHelper.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{

    /// <summary>
    /// Wrap up all sub interfaces
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.FacadeDesignPattern.DB" />
    public class FacadeHelper : DB
    {
        String DBType;

        public FacadeHelper()
        {
            DBType = null;
        }


        public FacadeHelper(String DBType)
        {
            this.DBType = DBType;
        }


        public Connection GetConnection()
        {

            switch(DBType)
            {
                case "SQL":
                   new SQLHelper().GetConnection();
                    break;
                case "ORACLE":
                    new OracleHelper().GetConnection();
                    break;
                default:
                    break;
            }
            return null;
        }

        public void GenerateHTMLReport()
        {
            switch (DBType)
            {
                case "SQL":
                    new SQLHelper().GenerateHTMLReport();
                    break;
                case "ORACLE":
                    new OracleHelper().GenerateHTMLReport();
                    break;
                default:
                    break;
            }

        }

        public void GeneratePDFReport()
        {
            switch (DBType)
            {
                case "SQL":
                    new SQLHelper().GeneratePDFReport();
                    break;
                case "ORACLE":
                    new OracleHelper().GeneratePDFReport();
                    break;
                default:
                    break;
            }
        }


        class SQLHelper : SQL
        {
            public  Connection GetConnection()
            {
                return new Connection();
            }

            public void GenerateHTMLReport()
            {
                Console.WriteLine("SQL HTML Report");
            }

            public void GeneratePDFReport()
            {
                Console.WriteLine("SQL PDF Report");
            }

        }


        class OracleHelper : ORACLE
        {
            public Connection GetConnection()
            {
                return new Connection();
            }

            public void GenerateHTMLReport()
            {
                Console.WriteLine("SQL HTML Report");
            }

            public void GeneratePDFReport()
            {
                Console.WriteLine("SQL HTML Report");
            }

        }

        public enum dbType{ SQL,ORACLE };
        public enum reportType { HTML,PDF };


    }
}
