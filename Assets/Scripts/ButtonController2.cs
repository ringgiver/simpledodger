using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController2 : MonoBehaviour
{
    public AudioSource audioSource; //사운드파일
    public GameObject hpPanel;
    public Text AddNumberButtonText; //누르면 숫자가 증가하는 버튼의 Text (시험용)
    public void OpenSplashScene()
    {
        SceneManager.LoadScene("Splash");
    }
    public void OpenGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void PlaySound()
    {
        //사운드를 재생한다...
        audioSource.Play();
    }
    
    public void ToggleHpPanel()
    {
        hpPanel.SetActive(hpPanel.activeSelf == false); //더 간단한 코딩
        //또는 hp.Panel.SetActive(!hpPanel.activeSelf);

        //if (hpPanel.activeSelf)
        //{
        //    hpPanel.SetActive(false);
        //}else{
        //    hpPanel.SetActive(true); } 
    }
    public void AddNumber()
    {
        var addNumber = PlayerPrefs.GetInt("ADD_NUMBER", 1);
        AddNumberButtonText.text = (addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);
        PlayerPrefs.Save();
    }
    public void Start()
    {
        
    }
}
