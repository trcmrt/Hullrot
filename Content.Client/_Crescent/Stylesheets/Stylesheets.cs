using System.Collections.Generic;
using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Maths;
using static Robust.Client.UserInterface.Stylesheet;
using static Robust.Client.UserInterface.StylesheetHelpers;


namespace Content.Client._Crescent.Stylesheets;

public static class CrescentStylesheet
{
    public const string CrescentButton = "CrescentButton";

    public static IEnumerable<StyleRule> Rules
    {
        get
        {
            yield return Element<Button>().Class(CrescentButton)
                .Prop(Button.StylePropertyStyleBox, new StyleBoxFlat
                {
                    BackgroundColor = Color.FromHex("#2A2420"),
                    BorderColor = Color.FromHex("#7A6135"),
                    BorderThickness = new Thickness(1),
                    ContentMarginLeftOverride = 12,
                    ContentMarginRightOverride = 12,
                    ContentMarginTopOverride = 6,
                    ContentMarginBottomOverride = 6,
                });

            yield return Element<Button>().Class(CrescentButton).Pseudo(Button.StylePseudoClassHover)
                .Prop(Button.StylePropertyStyleBox, new StyleBoxFlat
                {
                    BackgroundColor = Color.FromHex("#3A3028"),
                    BorderColor = Color.FromHex("#B09155"),
                    BorderThickness = new Thickness(1),
                    ContentMarginLeftOverride = 12,
                    ContentMarginRightOverride = 12,
                    ContentMarginTopOverride = 6,
                    ContentMarginBottomOverride = 6,
                });

            yield return Element<Button>().Class(CrescentButton).Pseudo(Button.StylePseudoClassPressed)
                .Prop(Button.StylePropertyStyleBox, new StyleBoxFlat
                {
                    BackgroundColor = Color.FromHex("#181412"),
                    BorderColor = Color.FromHex("#B09155"),
                    BorderThickness = new Thickness(1),
                    ContentMarginLeftOverride = 12,
                    ContentMarginRightOverride = 12,
                    ContentMarginTopOverride = 6,
                    ContentMarginBottomOverride = 6,
                });
        }
    }
}
