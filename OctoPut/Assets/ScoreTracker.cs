using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private static ScoreTracker _instance;
    private int _score = 0;

    private void Awake()
    {
        _instance = this;
    }

    public static void Success()
    {
        _instance.AddScore();
    }

    private void AddScore()
    {
        _score += 10;
        gameObject.GetComponentInChildren<Text>().text = "" + _score;
    }
}