
using UnityEngine;

namespace Uzai
{
    ///<summary>
    ///���ʨt��
    ///</summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;
    }
}