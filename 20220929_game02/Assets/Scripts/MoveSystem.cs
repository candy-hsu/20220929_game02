
using UnityEngine;

namespace Uzai
{
    ///<summary>
    ///移動系統
    ///</summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -2.5f;
        
        //transform 元件
        //Translate(x, y, z) 位移
        //Time.deltaTime 每秒幀數花費的時間
        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}