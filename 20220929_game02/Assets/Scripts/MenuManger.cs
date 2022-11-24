using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Uzai
{
    /// <summary>
    /// 選單管理器
    /// </summary>
    public class MenuManger : MonoBehaviour
    {
        /// <summary>
        /// start
        /// </summary>
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("start").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }
        /// <summary>
        /// start
        /// </summary>
        private void StartGame()
        {
            SceneManager.LoadScene("zone01");
        }

    }
}

