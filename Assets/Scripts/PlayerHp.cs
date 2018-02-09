using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{

    // public PlayerCollision playerCollsion;
    public PlayerHp playerHp;
    public int hp = 10;
    public Text hpText;
    public float LastAutoHealTime;
    public float autoHealInterval = 10f;
    private GameObject other;
    

    public void HealHp(int amount)
    {
        hp += amount; //hp = hp + amount;
        UpdateHp();
    }
    public void DamageHp(int amount)
    {
        hp -= amount; // hp = hp - amount ;
        UpdateHp();

    }
    private void UpdateHp()
    {
        hpText.text = hp.ToString();


    }

    private void Start()
    {
        //playerHp.hp--;

        hpText.text = hp.ToString();
        StartCoroutine(addHealth());
    }

    IEnumerator addHealth()
    {
        while (true)
        {
            if (hp < 10)
            {
                hp += 1;
                yield return new WaitForSeconds(5);
            }
            else
            {
                yield return null;
            }
        }
    }


    //private void Update()
    //{
    //    if (Time.time == LastAutoHealTime. autoHealInterval)
    //    {
    //        hp++;
    //    }

    //    if (other.tag == "Enemy")
    //    {
    //        DamageHp(1);
    //    }

    //private void OnDestroy()
    //{
    //    other.gameObject();
    //        }
    //}
    void Update()
    {
        if (hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //such as...
        //Destroy(GameObject);
        SceneManager.LoadScene("GameOver");
    }



    
}

