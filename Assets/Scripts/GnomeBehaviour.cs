using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GnomeBehaviour : MonoBehaviour
{
    public Image healthBar;
    public TMP_Text restartMessage; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //gnomes decrease princess health by 2 points 

        if(other.name == "Princess")
        {
            if (healthBar.fillAmount <= 0.2f)
            {
                //player dies and level restarts 
                healthBar.fillAmount = 0f;
                Destroy(gameObject);

                restartMessage.SetText("Game over. Try again.");

                StartCoroutine(resetScene());
            }
            else
            {
                healthBar.fillAmount -= 0.2f;
                healthBar.fillAmount = Mathf.Clamp01(healthBar.fillAmount);

                Destroy(gameObject);

                if(healthBar.fillAmount == 0f)
                {
                    restartMessage.SetText("Game over. Try again.");
                    StartCoroutine(resetScene());
                }
            }
        }
    }

    IEnumerator resetScene()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
