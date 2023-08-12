using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private Material selectedMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            if (selectionRenderer)
            {
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            }            
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectiorRenderer = selection.GetComponent<Renderer>();
            if (selectiorRenderer != null)
            {
                defaultMaterial = selectiorRenderer.material;
                selectiorRenderer.material = selectedMaterial;
            }
            _selection = selection;
        }
    }
}
