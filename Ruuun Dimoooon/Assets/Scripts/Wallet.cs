using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private static int _bestScore;
    private static int _score;
    private static int _money;

    public static int Money { get => _money; set => _money = value; }
    public static int Score { get => _score; set => _score = value; }
    public static int BestScore { get => _bestScore; set => _bestScore = value; }

    private void Start() {
        _score = 0;
        _bestScore =   PlayerPrefs.GetInt("BestScore");
    }
    public static void ChangeBestResult()
    {
        if (_bestScore < _score)
        {
            _bestScore = _score;
            PlayerPrefs.SetInt("BestScore", _bestScore);
        }
    }
    public static void ChangeMoney()
    {
        Money++;
        PlayerPrefs.SetInt("Money", Money);
    }
}
