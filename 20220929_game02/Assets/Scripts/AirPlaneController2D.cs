using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 飛機控制器2D模式
    /// </summary>
public class AirPlaneController2D : MonoBehaviour
{
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float SpeedVeatical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float SpeedHorizontal = 4;

        [Header("圖片")]
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

