﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using IDataAccessLayer;
using DataAccess.DC;

namespace BizLogic
{
    public class HomeBizLogic
    {
         private IHomeManager homeBase;

         public HomeBizLogic()
        {
            homeBase = new HomeManager();
        }

         public string GetNewNumber(string TypeName, string strFirstChar)
         {
             return homeBase.GetNewNumber(TypeName, strFirstChar);
         }
         public List<UserOperationLog> GetUserOperationList(string[] objectTypes, string objectValue)
         {
             return homeBase.GetOperationLogList(objectTypes, objectValue);
         }
    }
}
