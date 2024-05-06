/****************************************************
    文件：DetailInform.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine.UI;
using YFramework.Kit;
using YFramework.UI;

namespace Code_01.Controller
{
    public class DetailInform : UIBase
    {
        public string Inform;
        public void Init()
        {
            transform.Find("Text").GetComponent<Text>().text = Inform;
            transform.Find("BtnUse").GetComponent<Button>().onClick.AddListener(()=>MsgDispatcher.Register(Msg.Register.UseGoods, o =>
            {
                var itemData = o is ItemBase.ItemData ? (ItemBase.ItemData) o : default;
                //player.ChangeAll(itemData);
            }));
        }
    }
}