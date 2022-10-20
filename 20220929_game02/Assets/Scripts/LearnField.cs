
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 欄位的練習
    /// </summary>

    public class LearnField : MonoBehaviour
    {
        #region 欄位 語法 private
        //欄位 Field 儲存資料
        //語法：
        //private 修飾詞 私人 僅在此類別內能夠儲存,不顯示
        //int 資料類型 整數
        //level 欄位名稱 可更改該名稱
        private int Level;
        #endregion

        #region 欄位 語法 public 資料類型
        //等於 指定符號 將右邊的結果指定給左邊
        //public 公開 所有類別都能夠存取,顯示
        //int 整數
        public int Enemy = 100;
        //string 文字
        public string nameplayer = "美女";
        //float 小數點 後加f
        public float Speed = 5.5f;
        public float Jump = 7.8f;
        //bool 布林值 false true
        public bool isPass = false;
        public bool hasWeapon = true;
        #endregion

        #region 欄位屬性
        //Header 標題
        [Header("血量")]
        public int hp = 5;
        //Tooltip 提示
        [Tooltip("玩家打敗敵人的時間限制。")]
        public float Time = 8.8f;
        //Range 範圍 (最小值,最大值) 不支援int.float之外的資料類型
        [Range(1, 99)]
        public int Lv = 1;
        //Serialize Field 序列化欄位 顯示私人欄位
        [SerializeField]
        private float CountBoom = 5.5f;
        #endregion
    }

}