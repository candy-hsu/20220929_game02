
using UnityEngine;
namespace Uzai
{
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject 此腳本的遊戲物件
            //刪除(物件,刪除時間)
            Destroy(gameObject, destroyTime);
        }
        //可見事件：當Randerer出現在Scene或Game時執行一次
        private void OnBecameVisible()
        {
            
        }
        //不可見事件：當Rander消失在Scene或Game時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}
