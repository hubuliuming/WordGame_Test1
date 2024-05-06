
using System.Collections.Generic;
using UnityEngine;

namespace Code_01
{
    public class ExcelUtility 
    {
        public List<string> GetInfo(string itemName)
        {
            var dic = ExcelSystem.GetInfo(MsgPaths.RecoverItem, MsgPaths.RecoverItem, 1, 2000);
            return dic[itemName];
        }
    }
}