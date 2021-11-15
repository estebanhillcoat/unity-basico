//Se dispara un sonido UNA sola vez


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    
    public AudioSource quienEmite;
    public AudioClip elArchivoQueBaje;
    public float volumen = 1;
    bool seReprodujoAntes = false;


private void OnTriggerEnter(Collider other) {
    
    if (seReprodujoAntes == false) {

    quienEmite.PlayOneShot(elArchivoQueBaje,volumen);
    seReprodujoAntes = true;

    }



}
