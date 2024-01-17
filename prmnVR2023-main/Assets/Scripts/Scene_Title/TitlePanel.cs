using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NsUnityVr.Systems;

namespace NsUnityVr.Title
{
    public class TitlePanel : MonoBehaviour
    {
        [SerializeField] Button _startBtn = null;
        [SerializeField] Button _tuterealBtn = null;
		[SerializeField] Button _practicalBtn = null;//wip2023
		[SerializeField] Button _sleeptestBtn = null;//wip2023

		[SerializeField] Scene _startScene = Scene.Main;
        [SerializeField] Scene _tuterealScene = Scene.Title; // WIP
		[SerializeField] Scene _practicalScene = Scene.test; // WIPprmn2023
		[SerializeField] Scene _sleeptestScene = Scene.sleeptest; // WIPprmn2023


		void Start()
        {	
			//wip2023
			//var num_r = 0;
			//if
			//wip2023

            _startBtn.onClick.AddListener(() => {
                SEManager.Instance.PlaySE(SE.submit);
                SceneLoader.Instance.LoadTheScene(_startScene);
            });
            _tuterealBtn.onClick.AddListener(() => {
                SEManager.Instance.PlaySE(SE.submit);
                SceneLoader.Instance.LoadTheScene(_tuterealScene);
            });
			_practicalBtn.onClick.AddListener(() => {
				SEManager.Instance.PlaySE(SE.submit);
				SceneLoader.Instance.LoadTheScene(_practicalScene);
			});
			_sleeptestBtn.onClick.AddListener(() => {
				SEManager.Instance.PlaySE(SE.submit);
				SceneLoader.Instance.LoadTheScene(_sleeptestScene);
			});

		}
    }
}