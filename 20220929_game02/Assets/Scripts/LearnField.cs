
using UnityEngine;
namespace Candy
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
        #region 欄位 語法 public
        //等於 指定符號 將右邊的結果指定給左邊
        //public 公開 所有類別都能夠存取,顯示
        public int Enemy = 100;
        #endregion
    }

}