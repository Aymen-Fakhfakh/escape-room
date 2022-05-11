using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour
{
    [SerializeField] private GameObject popup ;
    [SerializeField] Text codeText;

    private Score s;
    private string path;

    private bool test  = true;
    
    void Start()
    {
        path = "/Data/gamedata.json"; 
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            s = new Score();
           
            string folderPath = Application.persistentDataPath + "/Data/";
            string filePath = folderPath + "gamedata.json";
        
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            File.WriteAllText(filePath, JsonUtility.ToJson(s));
            }
            else
            {
                
                string jsonString = LoadData(path);
                s = JsonUtility.FromJson<Score>(jsonString);
            }
    }
    
    void Update ()
    {
        
        if  (popup.activeInHierarchy == true  && test)
        {
            s.Upd() ;
            
            string folderPath = Application.persistentDataPath + "/Data/";
            string filePath = folderPath + "gamedata.json";
            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            File.WriteAllText(filePath, JsonUtility.ToJson(s));
            
            test = false;
        }
        else if (popup.activeInHierarchy == false) test = true;
        codeText.text = s.Get().ToString();

        if (s.val == 0)
        {
            SceneManager.LoadScene(7);
        }
    }

    [System.Serializable]
    class Score{
        public int val;
        public Score() { val = 100; }
        public void Upd() { val -= 10; }
        public int  Get() {return val; }
    }

    private string LoadData(string path)
    {
        string outputString = "";
        using (StreamReader sr = new StreamReader(Application.persistentDataPath + path))
        {
            string line;
            // Read and display lines from the file until the end of
            // the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                outputString += line;
            }
        }
        return outputString;
    }

}
