
using UnityEngine;

namespace Uzai
{
    ///<summary>
    ///���ʨt��
    ///</summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -2.5f;
        
        //transform ����
        //Translate(x, y, z) �첾
        //Time.deltaTime �C��V�ƪ�O���ɶ�
        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}