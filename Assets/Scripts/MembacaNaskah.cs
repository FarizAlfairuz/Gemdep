/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MembacaNaskah : MonoBehaviour
{
    //object untuk menulis percakapan
    public Text _teksUntukMenulisPercakapan;
    
    Queue<BahanPercakapan> _antrianNaskah;
    Queue<string> _antrianPercakapan;


    // Start is called before the first frame update
    void Start()
    {
        _antrianNaskah = new Queue<BahanPercakapan>();
        _antrianPercakapan = new Queue<string>();
    }

    public void mulaiPercakapan(BahanPercakapan[] _bp)
    {
        _teksUntukMenulisPercakapan.text = "";
        for (int i = 0; i < _bp.Length; i++)
        {
            _antrianNaskah.Enqueue(_bp[i]);
        }
        mulaiBaca();
    }

    void mulaiBaca()
    {
        BahanPercakapan a = _antrianNaskah.Dequeue();
        _namaPembicara.text = a.nama;
    }

    void baca()
    {
        string kata = _antrianPercakapan.Dequeue();
        -_teksUntukMenulisPercakapan.text = kata;

        if
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
*/