using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points;
    public ParticleSystem explosionParticle;
    private float lifeTime = 2f;
    private GameManager gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        //Autodestrucción tras 2 segundos
        Destroy(gameObject,lifeTime);
        gameManagerScript = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (!gameManagerScript.isGameOver)
        {
            gameManagerScript.UpdateScore(points);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(gameObject);

            if (gameObject.CompareTag("Bad"))
            {
                gameManagerScript.GameOver();
            }
        }
        

    }
    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);
    }
    
   
}
