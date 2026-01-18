using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
using TMPro;

public class ARInteraction : MonoBehaviour
{
    [Header("Paneller ve Metinler")]
    public GameObject rehberPanel;
    public TextMeshProUGUI rehberYazisi;
    public GameObject tebriklerPaneli;
    public GameObject tehlikePaneli;

    [Header("Modeller")]
    public GameObject masaObjesi;
    public GameObject dolapObjesi;

    private ARRaycastManager raycastManager;
    private ARPlaneManager planeManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private int yerlestirmeSirasi = 0;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        planeManager = GetComponent<ARPlaneManager>();

        masaObjesi.SetActive(false);
        dolapObjesi.SetActive(false);
        tebriklerPaneli.SetActive(false);
        tehlikePaneli.SetActive(false);

        // Baþlangýçta rehber açýk
        rehberPanel.SetActive(true);
        rehberYazisi.text = "Zemin taranýyor... Lütfen telefonu zemine doðru tut ve yavaþça hareket ettir.";
    }

    void Update()
    {
        // 1. ADIM: Zemin algýlandýðýnda yerleþtirme komutu ver
        if (yerlestirmeSirasi == 0 && planeManager.trackables.count > 0)
        {
            yerlestirmeSirasi = 1;
            rehberYazisi.text = "Zemin algýlandý! Hadi uygun yerlere sýrayla masa ve dolap yerleþtirelim. Önce masayla baþlayalým.";
        }

        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            Vector2 touchPos = Pointer.current.position.ReadValue();

            // YERLEÞTÝRME MODU
            if (raycastManager.Raycast(touchPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                if (yerlestirmeSirasi == 1) // Masa koyuluyor
                {
                    masaObjesi.transform.position = hitPose.position;
                    masaObjesi.transform.LookAt(new Vector3(Camera.main.transform.position.x, masaObjesi.transform.position.y, Camera.main.transform.position.z));
                    masaObjesi.SetActive(true);
                    yerlestirmeSirasi = 2;
                }
                else if (yerlestirmeSirasi == 2) // Dolap koyuluyor
                {
                    dolapObjesi.transform.position = hitPose.position;
                    dolapObjesi.transform.LookAt(new Vector3(Camera.main.transform.position.x, dolapObjesi.transform.position.y, Camera.main.transform.position.z));
                    dolapObjesi.SetActive(true);
                    yerlestirmeSirasi = 3;

                    // Yerleþtirme bitti, REHBER PANELÝ KAPANSIN
                    rehberPanel.SetActive(false);
                }
            }

            // ETKÝLEÞÝM MODU (Objelere týklama)
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Masa"))
                {
                    tebriklerPaneli.SetActive(true);
                    tehlikePaneli.SetActive(false);
                    KontrolEtVeBitir();
                }
                else if (hit.collider.CompareTag("Dolap"))
                {
                    tehlikePaneli.SetActive(true);
                    tebriklerPaneli.SetActive(false);
                    KontrolEtVeBitir();
                }
            }
        }
    }

    // Ýki objeye de bakýldýysa rehber paneli final mesajýyla tekrar açýlýr
    void KontrolEtVeBitir()
    {
        // Eðer her iki panel de en az bir kere açýldýysa (veya etkileþim saðlandýysa)
        if (yerlestirmeSirasi == 3)
        {
            rehberPanel.SetActive(true);
            rehberYazisi.text = "Görev tamamlandý! Artýk deprem anýnda ne yapman gerektiðini öðrendin. Gerçek bir kahramansýn";
        }
    }
}