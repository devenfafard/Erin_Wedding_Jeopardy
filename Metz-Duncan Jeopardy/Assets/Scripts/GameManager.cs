using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    #region SINGETON IMPLEMENTATION
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            // GM can't be found
            if (_instance == null)
            {
                // Search scene for instance
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject newGameManager = new GameObject("_GameManager");
                    _instance = newGameManager.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }

    #endregion

    //List<Player> players = new List<Player>();
    [SerializeField] string[] categoryNames = new string[5];
    [SerializeField] string[] category1Questions = new string[5];
    [SerializeField] string[] category2Questions = new string[5];
    [SerializeField] string[] category3Questions = new string[5];
    [SerializeField] string[] category4Questions = new string[5];
    [SerializeField] string[] category5Questions = new string[5];
    [SerializeField] private Transform[] _categoryHeaders = new Transform[5];
    [SerializeField] private Transform[] _categories;
    [SerializeField] private Transform _template;
    [SerializeField] private Canvas _questionPanel = null;
    [SerializeField] private Canvas _gameBoardPanel = null;
    [SerializeField] private Canvas _introPanel = null;
    [SerializeField] private float _duration = 0.0f;

    private CanvasGroup _questionCanvasGroup = null;
    private CanvasGroup _gameBoardCanvasGroup = null;
    private CanvasGroup _introPanelGroup = null;

    private void Awake()
    {
        _introPanelGroup = _introPanel.GetComponent<CanvasGroup>();

        _questionCanvasGroup = _questionPanel.GetComponent<CanvasGroup>();
        TurnOffPanel(_questionCanvasGroup, _questionPanel);

        for (int i = 0; i < _categoryHeaders.Length; i++)
        {
            TextMeshProUGUI text = _categoryHeaders[i].GetComponentInChildren<TextMeshProUGUI>();
            text.text = categoryNames[i];
        }

        InitFirstCategory();
        InitSecondCategory();
        InitThirdCategory();
        InitFourthCategory();
        InitFifthCategory();

        _gameBoardCanvasGroup = _gameBoardPanel.GetComponent<CanvasGroup>();
       //TurnOffPanel(_gameBoardCanvasGroup, _gameBoardPanel);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TurnOffPanel(_questionCanvasGroup, _questionPanel);
            StartCoroutine(Fade(_questionCanvasGroup, _questionCanvasGroup.alpha, 0));
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(Fade(_introPanelGroup, _introPanelGroup.alpha, 0));
            //TurnOffPanel(_introPanelGroup, _introPanel);
            //TurnOnPanel(_gameBoardCanvasGroup, _gameBoardPanel);
        }
    }
    
    private void InitFirstCategory()
    {
        List<Element_Question.ElementData> questionList1 = new List<Element_Question.ElementData>()
        {
            new Element_Question.ElementData
            {
                question = category1Questions[0],
                answer = "a butt",
                value = 200,
                onClick = () =>
                {
                    
                }
            },
            new Element_Question.ElementData
            {
                question = category1Questions[1],
                answer = "a foot",
                value = 400,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category1Questions[2],
                answer = "a foot",
                value = 600,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category1Questions[3],
                answer = "a foot",
                value = 800,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category1Questions[4],
                answer = "a foot",
                value = 1000,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            }
        };

        foreach (Element_Question.ElementData data in questionList1)
        {
            Element_Question temp = Instantiate(this._template, this._categories[0]).GetComponent<Element_Question>();
            temp.SetData(data);
            temp.gameObject.SetActive(true);
        }
    }

    private void InitSecondCategory()
    {
        List<Element_Question.ElementData> questionList2 = new List<Element_Question.ElementData>()
        {
            new Element_Question.ElementData
            {
                question = category2Questions[0],
                answer = "a butt",
                value = 200,
                onClick = () =>
                {
                    Debug.LogError("Butt");
                },
            },
            new Element_Question.ElementData
            {
                question = category2Questions[1],
                answer = "a foot",
                value = 400,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category2Questions[2],
                answer = "a foot",
                value = 600,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category2Questions[3],
                answer = "a foot",
                value = 800,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category2Questions[4],
                answer = "a foot",
                value = 1000,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            }
        };

        foreach (Element_Question.ElementData data in questionList2)
        {
            Element_Question temp = Instantiate(this._template, this._categories[1]).GetComponent<Element_Question>();
            temp.SetData(data);
            temp.gameObject.SetActive(true);
        }
    }

    private void InitThirdCategory()
    {
        List<Element_Question.ElementData> questionList3 = new List<Element_Question.ElementData>()
        {
            new Element_Question.ElementData
            {
                question = category3Questions[0],
                answer = "a butt",
                value = 200,
                onClick = () =>
                {
                    Debug.LogError("Butt");
                },
            },
            new Element_Question.ElementData
            {
                question = category3Questions[1],
                answer = "a foot",
                value = 400,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category3Questions[2],
                answer = "a foot",
                value = 600,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category3Questions[3],
                answer = "a foot",
                value = 800,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category3Questions[4],
                answer = "a foot",
                value = 1000,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            }
        };

        foreach (Element_Question.ElementData data in questionList3)
        {
            Element_Question temp = Instantiate(this._template, this._categories[2]).GetComponent<Element_Question>();
            temp.SetData(data);
            temp.gameObject.SetActive(true);
        }
    }

    private void InitFourthCategory()
    {
        List<Element_Question.ElementData> questionList4 = new List<Element_Question.ElementData>()
        {
            new Element_Question.ElementData
            {
                question = category4Questions[0],
                answer = "a butt",
                value = 200,
                onClick = () =>
                {
                    Debug.LogError("Butt");
                },
            },
            new Element_Question.ElementData
            {
                question = category4Questions[1],
                answer = "a foot",
                value = 400,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category4Questions[2],
                answer = "a foot",
                value = 600,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category4Questions[3],
                answer = "a foot",
                value = 800,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category4Questions[4],
                answer = "a foot",
                value = 1000,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            }
        };

        foreach (Element_Question.ElementData data in questionList4)
        {
            Element_Question temp = Instantiate(this._template, this._categories[3]).GetComponent<Element_Question>();
            temp.SetData(data);
            temp.gameObject.SetActive(true);
        }
    }

    private void InitFifthCategory()
    {
        List<Element_Question.ElementData> questionList5 = new List<Element_Question.ElementData>()
        {
            new Element_Question.ElementData
            {
                question = category5Questions[0],
                answer = "a butt",
                value = 200,
                onClick = () =>
                {
                    Debug.LogError("Butt");
                },
            },
            new Element_Question.ElementData
            {
                question = category5Questions[1],
                answer = "a foot",
                value = 400,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category5Questions[2],
                answer = "a foot",
                value = 600,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category5Questions[3],
                answer = "a foot",
                value = 800,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            },
            new Element_Question.ElementData
            {
                question = category5Questions[4],
                answer = "a foot",
                value = 1000,
                onClick = () =>
                {
                    Debug.LogError("foot");
                },
            }
        };

        foreach (Element_Question.ElementData data in questionList5)
        {
            Element_Question temp = Instantiate(this._template, this._categories[4]).GetComponent<Element_Question>();
            temp.SetData(data);
            temp.gameObject.SetActive(true);
        }
    }

    #region UI Stuff
    private void TurnOnPanel(CanvasGroup group, Canvas canvas)
    {
        group.alpha = 1;
        group.interactable = true;
        group.blocksRaycasts = true;
        canvas.sortingOrder = 10;
    }

    private void TurnOffPanel(CanvasGroup group, Canvas canvas)
    {
        group.alpha = 0;
        group.interactable = false;
        group.blocksRaycasts = false;
        canvas.sortingOrder = 0;
    }

    public void DisplayQuestion(string questionText)
    {
        TextMeshProUGUI question = this._questionPanel.GetComponentInChildren<TextMeshProUGUI>();
        question.text = questionText;

        TurnOnPanel(this._questionCanvasGroup, this._questionPanel);
    }

    public void FadeIntroOut()
    {
        StartCoroutine(Fade(_introPanelGroup, _introPanelGroup.alpha, 0));
    }

    public IEnumerator Fade(CanvasGroup group, float start, float end)
    {
        float counter = 0.0f;
        group.interactable = false;
        group.blocksRaycasts = false;

        while (counter < _duration)
        {
            counter += Time.deltaTime;
            group.alpha = Mathf.Lerp(start, end, counter / _duration);

            yield return null;
        }
    }
    #endregion
}