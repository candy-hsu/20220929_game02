
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 玩家發射
    /// </summary>
    public class PlayerFireSytem : FireSystemBase
    {
        //偵測玩家輸入行為：鍵盤、滑鼠、搖桿
        private void Update()
        {
            //如果 玩家 按下空白鍵 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

