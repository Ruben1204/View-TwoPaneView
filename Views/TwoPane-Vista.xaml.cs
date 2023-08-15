using Microsoft.Maui.Controls.Foldable;

namespace TwoPaneApp.Views;

public partial class TwoPane_Vista : ContentPage
{
	public TwoPane_Vista()
	{
		InitializeComponent();
        ConfigureTwoPaneViewModes();
    }
    private void ConfigureTwoPaneViewModes()
    {
        //Configurar los modos disponibles
        pantallaPlegable.TallModeConfiguration = TwoPaneViewTallModeConfiguration.TopBottom;
        pantallaPlegable.WideModeConfiguration = TwoPaneViewWideModeConfiguration.LeftRight;

        //Establecer el modo inicial

        if (pantallaPlegable.Mode == TwoPaneViewMode.Wide)
        {
            pantallaPlegable.TallModeConfiguration = TwoPaneViewTallModeConfiguration.BottomTop;
            pantallaPlegable.PanePriority = TwoPaneViewPriority.Pane2;
        }
        else if (pantallaPlegable.Mode == TwoPaneViewMode.Tall)

        {
            pantallaPlegable.WideModeConfiguration = TwoPaneViewWideModeConfiguration.RightLeft;
            pantallaPlegable.PanePriority = TwoPaneViewPriority.Pane2;
        }
    }
}