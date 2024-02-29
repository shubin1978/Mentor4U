using System.Windows.Controls;

namespace Mentor4U.WpfClassic.Components.VisualComponent;

public partial class VisualComponent : UserControl
{
    public Image Picture {
        get;
        set;
    }

    public string Text { get; set; }
    public VisualComponent()
    {
        InitializeComponent();
        DataContext = this;
    }
}