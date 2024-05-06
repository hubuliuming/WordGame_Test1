using UnityEngine;

namespace Code_01
{
    public class MsgPaths
    {
        public static readonly string RecoverItem = "RecoverItem";
        public struct Config
        {
            public static readonly string PlayerData = Application.dataPath + "/Data/Player";
            public static readonly string RecoverItem = Application.streamingAssetsPath + "/Data/RecoverItem";
            public static readonly string Enemy = Application.streamingAssetsPath + "/Data/Enemy";
        }
    }
}