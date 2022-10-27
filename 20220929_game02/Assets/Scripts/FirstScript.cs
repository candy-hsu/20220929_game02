
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 第一次的C++
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 註解
        // 單行註解
        /* 多行註解
         * 
         */
        //A a 不同字
        #endregion
        #region 事件
        private void Awake()
        {
            print("Hello world!");
        }
        private void Update()
        {
            print("<b><color=#800080ff>我超級聰明</color></b>");
        }
        #endregion

    }
}