using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _value = 0;

    public void Add(int amount)
    {
        _value += amount;
        _text.text = "Score: " + _value.ToString();
    }
}
