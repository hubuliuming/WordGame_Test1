/****************************************************
    文件：GoodsFactorySystem.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using QFramework;
using UnityEngine;
using UnityEngine.Pool;

public class GoodsFactorySystem : AbstractSystem 
{
    protected override void OnInit()
    {
        throw new System.NotImplementedException();
    }

    public ObjectPool<GameObject> GetPool(string poolName)
    {
        throw new System.NotImplementedException();
    }
}