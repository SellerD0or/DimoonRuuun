using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    [SerializeField] private Text _moneyText;
    [SerializeField] private Text _scoreText;
    private int _bestScore;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _bestResult;
    [SerializeField] private GameObject _delete;
    [SerializeField] private Text _bestResultText;
    private int _money;
   private void Start() {
     _money =  PlayerPrefs.GetInt("Money");
     _moneyText.text ="У вас: " + _money.ToString() + " монет";
       _bestScore = PlayerPrefs.GetInt("BestScore");
       _bestResultText.text = "Лучший результат: " + _bestScore.ToString();
   }
   public void Play()
   {
       _bestScore = PlayerPrefs.GetInt("BestScore");
       _bestResultText.text = "Лучший результат: " + _bestScore.ToString();
       _moneyText.gameObject.SetActive(false);
       Player.IsPlay = true;
       _bestResult.SetActive(false);
         _delete.SetActive(false);
       _button.SetActive(false);
       _scoreText.gameObject.SetActive(true);
       ChangeText(0);
      
   }
   public void DeleteInfo()
   {
       PlayerPrefs.DeleteAll();
       Wallet.ChangeMoney();
       Wallet.ChangeBestResult();
       Wallet.BestScore = 0;
       Wallet.Money = 0;
       _bestScore = PlayerPrefs.GetInt("BestScore");
       _bestResultText.text = "Лучший результат: " + _bestScore.ToString();
        _money =  PlayerPrefs.GetInt("Money");
     _moneyText.text ="У вас: " + _money.ToString() + " монет";
   }
   public void EndGame()
   {
       _delete.SetActive(true);
     Player.IsPlay = false;
     _bestResult.SetActive(true);
     _button.SetActive(true);
     Wallet.ChangeBestResult();
      SceneManager.LoadScene(0);
     
   }
   public void ChangeText(int _score)
   {
       
       _scoreText.text = "Ваш результат: " + _score.ToString();
   }
}
