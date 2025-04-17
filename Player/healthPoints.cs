//How To DAMAGE Enemies in Unity
//BMo
//Accessed 2 April 2025
//Version 3
//https://youtu.be/anHxFtiVuiE?si=SiLtQANzkFOzqH29
using UnityEngine;


public class healthPoints : MonoBehaviour
{
    public int maxHeatlh = 30;
    public int currentHealth = 0;
    public float personalDmg = 20f;

    void Start()
    {
        currentHealth = maxHeatlh;
    }

    public void RecieveDamage(int damageTaken)  //This method is called in the projectile script when the enemy lands a shot on the player 
    {
        currentHealth -= damageTaken;
        if (currentHealth <= 0)
        {

            Die();
        }

        void Die()
        {
            Destroy(gameObject);
           
            //Need to also spawn a gameover screen from here 

        }
    }
}
