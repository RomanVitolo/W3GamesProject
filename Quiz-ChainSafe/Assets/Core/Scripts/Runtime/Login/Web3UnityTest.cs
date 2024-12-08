using System;
using ChainSafe.Gaming.UnityPackage;
using UnityEngine;

namespace Core.Runtime
{
    public class Web3UnityTest : MonoBehaviour
    {
        [SerializeField] private string _ercContractAddress;
        [SerializeField] private string _ercAccountBalance;

        private async void Start()
        {
            try
            {
                await Web3Unity.Instance.Initialize(false);
                var balance = await Web3Unity.Web3.Erc20.GetBalanceOf(_ercContractAddress, _ercAccountBalance);
                Debug.Log($"Balance of {balance}");
            }
            catch (Exception e)
            {
                Debug.LogWarning(e.Message);
            }
        }
    }
}
