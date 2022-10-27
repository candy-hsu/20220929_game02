using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// �������2D�Ҧ�
    /// </summary>
public class AirPlaneController2D : MonoBehaviour
{
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float SpeedVeatical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float SpeedHorizontal = 4;

        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite PictureUp;
        [SerializeField]
        private Sprite PictureMiddle;
        [SerializeField]
        private Sprite PictureDown;

        private void Update()
        {
            transform.Translate(SpeedHorizontal * Time.deltaTime, SpeedVeatical * Time.deltaTime, 0);
        }



    }

}

