using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using String;

public class score : MonoBehaviour
{
    [SerializeField] private GameObject popup ;
    [SerializeField] Text codeText;

    private Score s;
    private string path;

    private bool test  = true;
    
    void Start(){
        path = Application.dataPath + "/Data/gamedata.json"; 
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            s = new Score();
            //Debug.Log( JsonUtility.ToJson(s) );
            File.WriteAllText(path, JsonUtility.ToJson(s) );
        }else{
            s = JsonUtility.FromJson<Score>(File.ReadAllText (path));
        }
    }
    
    void Update ()
    {
        /*if ( SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("scene1"))
        {
            s = 100 ;
            codeText.text = ""+s ;
        }
        if ( SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("scene2") )
        {
            codeText.text = "" + s ;
        }
        if ( SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("scene3") )
        {
            codeText.text = "" + s ;
        }
        if ( SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("scene4") )
        {
            codeText.text = "" + s ;
        }
        */
        if  (popup.activeInHierarchy == true  && test)
        {
            s.Upd() ;
            string json = JsonUtility.ToJson(s);
            File.WriteAllText(path, json );
            test = false;
        }
        else if (popup.activeInHierarchy == false) test = true;
        codeText.text = s.Get().ToString();

        /*if (s.Score == 0)
        {
            SceneManager.LoadScene(7);
        }*/
    }

    [System.Serializable]
    class Score{
        public int val;
        public Score() { val = 100; }
        public void Upd() { val -= 10; }
        public int  Get() {return val; }
    }


}
