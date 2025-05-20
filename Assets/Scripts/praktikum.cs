using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class praktikum : MonoBehaviour
{
    // public int health = 100; //Integer
    // public float speed = 5.5f; //float (desimal)
    // public bool isAlive = true; //boolean (true/false)
    // public string playerName = "palmaker"; //string (teks)
    // public char grade = 'A'; //char (satu karakter)
    // public int health = 100;
    // int damage = 20;
    // public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Nama Pemain: " + playerName);
        //Debug.Log("Nyawa Pemain: " + health);
        //Debug.Log("Status Pemain: " + isAlive);
        //Debug.Log("kecepatan Pemain: " + speed);
        //Debug.Log("title Pemain: " + grade);

        //operator dasar
        // int damage = 20;
        // health = health - damage; //pengurangan darah
        // Debug.Log("Nyawa sekarang: " + health);

        // bool isDead = (health <= 0);
        // Debug.Log("Kondisi player saat ini: " + isDead);

        // //operator logika
        // if (isAlive && health > 0)
        // {
        //     Debug.Log("Pemain masih hidup");
        // }
        // else {
        //     Debug.Log("Pemain telah dikalahkan");
        // }
        // ;

        // health = health - damage;

        // if(health > 50){
        //     Debug.Log("Nyawa player masih banyak");
        // }
        // else if (health > 0){
        //     Debug.Log("Nyawa player tinggal sedikit");
        // }
        // else {
        //     Debug.Log("Nyawa player sudah habis");
        //     isAlive = false;
        // }

        //looping for
        // for(int i = 1;i <=5; i++ ){
        //     Debug.Log("terkena hit sebanyak: " + i + "kali");
        // }

        //looping foreach
        // int[] scores = {100, 80 ,60 ,40 ,20};
        // foreach(int score in scores) {
        //     Debug.Log("Skor akhir: " + score);
        // }

        //looping while

        // displayPlayerName("palmaker");

        // string status = GetPlayerStatus(50);
        // Debug.Log("Status Pemain" + status);

        StartCoroutine(ContohCorotine());
    }

    // Update is called once per frame
    void Update() { }

    // void displayPlayerName(String playerName){
    //     Debug.Log("Nama player: " + playerName);
    // }

    // string GetPlayerStatus(int health) {

    //     if(health >= 50){
    //         return "Nyawa player masih banyak";
    //     }
    //     else if (health > 0){
    //         return "Nyawa player tinggal sedikit";
    //     }
    //     else{
    //         return "Nyawa player sudah habis";
    //     }
    //  }

    IEnumerator ContohCorotine(){
        Debug.Log("Start Corotine");
        yield return new WaitForSeconds(2f);
        Debug.Log("Corotine selesai");
    }
}
