﻿using UnityEngine;

public class DynamicObjectSound : MonoBehaviour
{
    [SerializeField] private Attribute attribute;

    private SoundEffecter _soundEffecter;
    private SoundEffecter soundEffecter
    {
        get
        {
            return _soundEffecter ? _soundEffecter : (_soundEffecter = GameObject.FindWithTag ("AudioManager").GetComponent<SoundEffecter> ());
        }
    }

    public void Play ()
    {
        soundEffecter.Play (attribute);
    }

    public void OnCollisionEnter (Collision collision)
    {
        Play ();
    }
}