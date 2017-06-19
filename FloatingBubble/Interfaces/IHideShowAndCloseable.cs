namespace FloatingBubble.Interfaces
{
    /// <summary>
    /// Interface with main reason to preserve the MVVM pattern --> buisness logic not knowing about views
    /// Interface making sure that one can hide, how and close a window
    /// </summary>
    [System.Obsolete("Using now boolean value to switch")]
    interface IHideShowAndCloseable
    {
        void Close();

        void Hide();

        void Show();
    }
}
