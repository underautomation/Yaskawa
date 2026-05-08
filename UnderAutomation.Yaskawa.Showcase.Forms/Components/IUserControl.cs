using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;

public interface IUserControl : IContainerControl
{
    // Title of the user control
    string Title { get; }

    // Indicates if the feature shown is enabled
    bool FeatureEnabled { get; }

    // Called periodically in GUI thread
    void PeriodicUpdate();

    // Called when the control is displayed
    void OnOpen();

    // Called when the control is replaced by another
    void OnClose();

}

public interface ISelectableControl<T> : IUserControl where T:IYaskawaClient
{
    T SelectedProtocol { get; set; }

    YaskawaRobot Robot { get; set; }
}