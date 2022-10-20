
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// ��쪺�m��
    /// </summary>

    public class LearnField : MonoBehaviour
    {
        #region ��� �y�k private
        //��� Field �x�s���
        //�y�k�G
        //private �׹��� �p�H �Ȧb�����O������x�s,�����
        //int ������� ���
        //level ���W�� �i���ӦW��
        private int Level;
        #endregion

        #region ��� �y�k public �������
        //���� ���w�Ÿ� �N�k�䪺���G���w������
        //public ���} �Ҧ����O������s��,���
        //int ���
        public int Enemy = 100;
        //string ��r
        public string nameplayer = "���k";
        //float �p���I ��[f
        public float Speed = 5.5f;
        public float Jump = 7.8f;
        //bool ���L�� false true
        public bool isPass = false;
        public bool hasWeapon = true;
        #endregion

        #region ����ݩ�
        //Header ���D
        [Header("��q")]
        public int hp = 5;
        //Tooltip ����
        [Tooltip("���a���ѼĤH���ɶ�����C")]
        public float Time = 8.8f;
        //Range �d�� (�̤p��,�̤j��) ���䴩int.float���~���������
        [Range(1, 99)]
        public int Lv = 1;
        //Serialize Field �ǦC����� ��ܨp�H���
        [SerializeField]
        private float CountBoom = 5.5f;
        #endregion
    }

}