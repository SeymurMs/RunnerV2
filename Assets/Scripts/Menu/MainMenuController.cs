using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Animator Transition;

    public RectTransform[] Pages;
    public RectTransform ActivePage;
    public RectTransform PreviusPage;
    public float GOGOGOG = 1050f;
    public float Time = 1f;
    public float BACKBACK = 0f;

    private void Awake()
    {
        PreviusPage = Pages[0];
        ActivePage = PreviusPage;
    }

    public void GoRaiting()
    {
        PreviusPage = ActivePage;
        ActivePage = Pages[1];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }
    public void BackStartMenu()
    {
        PreviusPage = ActivePage;
        ActivePage = Pages[0];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }

    public void GoReception() {
        PreviusPage = ActivePage;
        ActivePage = Pages[2];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }
    public void BackMainMenu() 
    {
        PreviusPage = ActivePage;
        ActivePage = Pages[0];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }
    public void GoInfo()
    {
        PreviusPage = ActivePage;
        ActivePage = Pages[3];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }
    public void GoControl()
    {
        PreviusPage = ActivePage;
        ActivePage = Pages[4];
        PreviusPage.DOAnchorPosY(GOGOGOG, Time).OnComplete(() =>
        {
            PreviusPage.gameObject.SetActive(false);
            ActivePage.gameObject.SetActive(true);
            ActivePage.DOAnchorPosY(BACKBACK, Time);
        });
    }
    public void StartGame()
    {
        StartCoroutine(TransitionAnim()); 
    }
    IEnumerator TransitionAnim()
    {
        Transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);

    }
}
