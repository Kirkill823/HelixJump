using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class deathAnimation : MonoBehaviour

{
    public Material material;
    public Player Player;

    public void Start()
    {
    

    }

     IEnumerable CoroutineSample()
    {
      

        material = GetComponent<MeshRenderer>().material;

        yield return new WaitForSeconds(1f);

        material.SetFloat("_DisForMount", 0.2f);

        yield return new WaitForSeconds(1f);

        material.SetFloat("_DisForMount", 0.5f);

        yield return new WaitForSeconds(1f);

        material.SetFloat("_DisForMount", 0.8f);

        yield return new WaitForSeconds(1f);

        material.SetFloat("_DisForMount", 1f);

        yield return new WaitForSeconds(1f);

        ReloadLevel();
    }
    void ReloadLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
     }
}
