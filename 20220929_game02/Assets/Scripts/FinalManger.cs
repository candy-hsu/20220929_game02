using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
namespace Uzai
{
    /// <summary>
    /// �����޲z��
    /// </summary>
    public class FinalManger : MonoBehaviour
    {
        public static FinalManger instance;

        /// <summary>
        /// �����e��
        /// </summary>
        private CanvasGroup groupFinal;

        /// <summary>
        /// �������D
        /// </summary>
        private TextMeshProUGUI texTitle;

        /// <summary>
        /// ���s�C��
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("�����e��").GetComponent<CanvasGroup>();
            texTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// �C������
        /// </summary>
        /// <param name="title">�C�����D</param>
        public void GameOver(string title)
        {
            texTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// �H�J
        /// </summary>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;


        }

        /// <summary>
        /// ���s�C��
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("start");
        }
    }
}



