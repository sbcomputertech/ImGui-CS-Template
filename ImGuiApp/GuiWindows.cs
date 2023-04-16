using ImGuiNET;
using System.Numerics;

namespace ImGuiNetApp;

internal static class GuiState
{
    public static string WindowTitle = "ImGui.NET Window";
    public static Vector3 WindowBackgroundColor = Vector3.One;
}

internal static class GuiWindows
{
    internal static void CallAllWindows()
    {
        MainWindow();
    }

    private static void MainWindow()
    {
        ImGui.Begin("ImGui.NET Template App");
        ImGui.InputText("Window title", ref GuiState.WindowTitle, 100);
        ImGui.ColorEdit3("Background color", ref GuiState.WindowBackgroundColor);
        if (ImGui.Button("Exit"))
        {
            Environment.Exit(0);
        }
        ImGui.End();
    }
}