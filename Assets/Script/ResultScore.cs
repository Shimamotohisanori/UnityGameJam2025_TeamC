using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    public Shell shell; // Shell�N���X�̃C���X�^���X���Q�Ƃ��邽�߂̕ϐ�

    public int Resultscore; // �X�R�A��ێ�����ϐ�
    public TextMeshProUGUI ResultText; // �X�R�A��\�����邽�߂�TextMeshProUGUI�R���|�[�l���g
    // Start is called before the first frame update
    void Start()
    {
        Resultscore = Shell.Score; // Shell�N���X�̐ÓI�ϐ�Score����X�R�A���擾
        ResultText.text = "Score: " + Resultscore; // �X�R�A���e�L�X�g�ɐݒ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
