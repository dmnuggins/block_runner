using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public float slowMoFactor = 10f;

    public void EndGame()
    {
        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame()
    {
        Time.timeScale = 1f / slowMoFactor;
        Time.fixedDeltaTime /= slowMoFactor;

        yield return new WaitForSeconds(1f / slowMoFactor);


        Time.timeScale = 1f;
        Time.fixedDeltaTime *= slowMoFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
