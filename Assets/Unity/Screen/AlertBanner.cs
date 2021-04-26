using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AlertBanner: MonoBehaviour {

    // MARK: - Property

    public Text text;
    private static AlertBanner presenting;

    private static readonly string prefabName = "AlertBanner";
    private readonly float lifetime = 10.0f;

    // MARK: - Lifecycle

    void Start() {
        Destroy(gameObject, lifetime);
    }

    // MARK: - Public

    public static void show(string description) {
        if (presenting != null) { Destroy(presenting.gameObject); }

        var prefab = Resources.Load(prefabName) as GameObject;
        var instance = Instantiate(prefab);

        var component = instance.GetComponent<AlertBanner>();
        component.text.text = description;

        presenting = component;
    }
}
