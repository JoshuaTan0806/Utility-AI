using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatManager : MonoBehaviour
{
    public static StatManager instance;
    public List<Stat> Stats;

    public AIStats SelectedUnit;

    public GameObject StatUIHolderPrefab;
    GameObject StatUIHolder;
    public GameObject StatUIPrefab;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        SelectUnit();
    }

    void SelectUnit()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RemoveStats();
            SelectedUnit = null;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent(out AIStats stats))
                {
                    SelectedUnit = stats;
                    ShowStats();
                }
            }
        }
    }

    void ShowStats()
    {
        StatUIHolder = Instantiate(StatUIHolderPrefab);

        for (int i = 0; i < SelectedUnit.stats.Count; i++)
        {
            GameObject G = Instantiate(StatUIPrefab, StatUIHolder.transform.GetChild(0));
            G.GetComponent<TextMeshProUGUI>().text = SelectedUnit.stats[i].Name + ": " + SelectedUnit.stats[i].Value;
        }
    }

    void RemoveStats()
    {
        if (StatUIHolder != null)
            Destroy(StatUIHolder);
    }
}
