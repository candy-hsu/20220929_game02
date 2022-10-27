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
        private float SpeedVertical = 3.5f;
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
            //上下 ws Vertical
            //左右 ad Horizontal
            //上 W +1
            //下 S -1
            //右 D +1
            //左 A -1
            //沒按 0
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(SpeedHorizontal * Time.deltaTime * h, SpeedVertical * Time.deltaTime * v, 0);
        }



    }

}

