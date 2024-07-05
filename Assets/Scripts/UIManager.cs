using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject _mainMenuPanel;
    [SerializeField] GameObject _howToMoveInstructionPanel;
    [SerializeField] GameObject _informationPanel;
    [SerializeField] GameObject _whatsNewPanel;
    [SerializeField] GameObject _gameSettingsPanel;
    [SerializeField] GameObject _onePlayerSettingPartPanel;
    [SerializeField] GameObject _twoPlayerSettingPartPanel;
    [SerializeField] GameObject _threePlayerSettingPartPanel;
    [SerializeField] GameObject _fourPlayerSettingPartPanel;

    public void ChangeMainMenuPanelState()
    {
        _mainMenuPanel.SetActive(!_mainMenuPanel.activeSelf);
    }

    public void ChangeToHowToMoveInstructionPanelState()
    {
        _howToMoveInstructionPanel.SetActive(!_howToMoveInstructionPanel.activeSelf);
    }

    public void ChangeInformationPanelState()
    {
        _informationPanel.SetActive(!_informationPanel.activeSelf);
    }

    public void ChangeWhatsNewPanelState()
    {
        _whatsNewPanel.SetActive(!_whatsNewPanel.activeSelf);
    }

    public void ChangeGameSettingsPanelState()
    {
        _gameSettingsPanel.SetActive(!_gameSettingsPanel.activeSelf);
    }

    public void ChangeOnePlayerSettingPartState()
    {
        _onePlayerSettingPartPanel.SetActive(!_onePlayerSettingPartPanel.activeSelf);
    }

    public void ChangeTwoPlayerSettingPartState()
    {
        _twoPlayerSettingPartPanel.SetActive(!_twoPlayerSettingPartPanel.activeSelf);
    }

    public void ChangeThreePlayerSettingPartState()
    {
        _threePlayerSettingPartPanel.SetActive(!_threePlayerSettingPartPanel.activeSelf);
    }

    public void ChangeFourPlayerSettingPartState()
    {
        _fourPlayerSettingPartPanel.SetActive(!_fourPlayerSettingPartPanel.activeSelf);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
