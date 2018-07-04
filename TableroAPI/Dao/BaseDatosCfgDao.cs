using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
namespace TableroControl.Dao
{
    public class BaseDatosCfgDao : SFP.Persistencia.Dao.BaseDao
    {
        public const int MSSQL_SPTABLES_QUALIFIER = 0;
        public const int MSSQL_SPTABLES_OWNER = 1;
        public const int MSSQL_SPTABLES_NAME = 2;
        public const int MSSQL_SPTABLES_TYPE = 3;
        public const int MSSQL_SPTABLES_REMARKS = 4;


        //COLUMN_NAME     PK_NAME
        public const int MSSQL_SPKEYS_DB = 0;
        public const int MSSQL_SPKEYS_OWNER = 1;
        public const int MSSQL_SPKEYS_TABLE = 2;
        public const int MSSQL_SPKEYS_FIELD = 3;
        public const int MSSQL_SPKEYS_COLID = 4;
        public const int MSSQL_SPKEYS_CONSTRAIN = 5;


        public const string LLAVE_PRIMARIA = "P";
        public const string LLAVE_FORANEA = "F";

        public BaseDatosCfgDao(DbConnection cn, DbTransaction transaction, String sDataAdapter)
            : base(cn, transaction, sDataAdapter)
        {
        }

      
    }
}
