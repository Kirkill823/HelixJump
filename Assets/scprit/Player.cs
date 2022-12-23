using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float BouceSpeed;
    public Rigidbody rigidbody;
    public Platform CurrentPlatform;
    public Game Game;
    public Material material;
    public deathAnimation deathAnimation;



    public void Bounce()
    {
        rigidbody.velocity = new Vector3(0, BouceSpeed, 0);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    public void Die()
    {
       StartCoroutine((IEnumerator)CoroutineSample());
        rigidbody.velocity = Vector3.zero;

    }

    public void ReachFinish()
    {
        Game.OnPlaerReachFinish();
        rigidbody.velocity = Vector3.zero;
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
