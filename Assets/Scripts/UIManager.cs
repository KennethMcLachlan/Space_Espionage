using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _collectableText;

    [SerializeField]
    TextMeshProUGUI _livesText;

    [SerializeField]
    private GameObject _gameOver;

    [SerializeField]
    TextMeshProUGUI _employeeText;

    public void UpdateCollectableDisplay(int collectable)
    {
        _collectableText.text = "x" + collectable.ToString("00");
    }

    public void UpdateLives(int lives)
    {
        _livesText.text = "Lives x" + lives.ToString("00");
    }

    public void GameOver()
    {
        _gameOver.SetActive(true);
    }

    public void UpdateEmployee()
    {
        StartCoroutine(EmployeeConvoRoutine());
    }

    IEnumerator EmployeeConvoRoutine()
    {
        _employeeText.text = "Hey! You're not supposed to be here!";
        yield return new WaitForSeconds(3);

        _employeeText.text = "My job sucks so I'll cut you a deal.";
        yield return new WaitForSeconds(3);

        _employeeText.text = "If you bring me 10 power cells, I'll let you use the ladder.";
        yield return new WaitForSeconds(3);

        //if power cell count > 10 Set Ladder to active
        //else
    }
}
